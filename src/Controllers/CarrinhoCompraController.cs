﻿using AutoMapper;
using LojaVirtual.Controllers.Base;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Seguranca;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
	public class CarrinhoCompraController : BaseController
	{
		private readonly ILogger<CarrinhoCompraController> _logger;
		public CarrinhoCompraController(ILogger<CarrinhoCompraController> logger, LoginCliente loginCliente, IEnderecoEntregaRepository enderecoEntregaRepository, CookieFrete cookieValorPrazoFrete, CalcularPacote calcularPacote, WSCorreiosCalcularFrete wscorreios, IMapper mapper, CookieCarrinhoCompra cookieCarrinhoCompra, IProdutoRepository produtoRepository)
			: base(loginCliente, enderecoEntregaRepository, cookieValorPrazoFrete, calcularPacote, wscorreios, mapper, cookieCarrinhoCompra, produtoRepository)
		{ 
			_logger = logger;
		}
		public IActionResult Index()
		{
			List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();
			return View(produtoItemCompleto);
		}

		public IActionResult VerificarEstoque()
		{
			List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();
			foreach (var produto in produtoItemCompleto)
			{
				if (produto.Estoque <= 0)
				{
					ViewBag.MSG_E = Mensagem.MSG_E008;
					return View("Index", produtoItemCompleto);
				}
				if (produto.Estoque < produto.UnidadesPedidas)
				{
                    ViewBag.MSG_E = Mensagem.MSG_E008;
                    return View("Index", produtoItemCompleto);
                }
			}

			return RedirectToAction(nameof(EnderecoEntrega));
		}

        public IActionResult AdicionarItem(int id)
		{
			Produto produto = _produtoRepository.ObterProduto(id);
			if (produto == null)
			{

				return View("NaoExisteItem");
			}
			else
			{
				var item = new ProdutoItem() { Id = id, UnidadesPedidas = 1};
				_cookieCarrinhoCompra.Cadastrar(item);

				return RedirectToAction(nameof(Index));
			}
		}

		public IActionResult AlterarQuantidade(int id, int quantidade)
		{
			Produto produto = _produtoRepository.ObterProduto(id);
			if (quantidade < 1)
			{
				return BadRequest(new { mensagem = Mensagem.MSG_E007 });
			}
			else if (quantidade > produto.Estoque)
			{
				return BadRequest(new { mensagem = Mensagem.MSG_E008 });
			}
			else
			{
				var item = new ProdutoItem() { Id = id, UnidadesPedidas = quantidade };
				_cookieCarrinhoCompra.Atualizar(item);
				return Ok(new { mensagem = Mensagem.MSG_S001 });
			}
		}

		public IActionResult RemoverItem(int id)
		{
			_cookieCarrinhoCompra.Remover(new ProdutoItem() { Id = id });
			return RedirectToAction(nameof(Index));
		}

		[ClienteAutorizacao]
		public IActionResult EnderecoEntrega()
		{
			Cliente cliente = _loginCliente.GetCliente();
			IList<EnderecoEntrega> enderecos = _enderecoEntregaRepository.ObterTodosEnderecoEntregaCliente(cliente.Id);

			ViewBag.Produtos = CarregarProdutoDB();

			ViewBag.Cliente = cliente;
			ViewBag.Enderecos = enderecos;

			return View();
		}

		public async Task<IActionResult> CalcularFrete(int cepDestino)
		{
			try
			{
				//Verifica se existe no Frete o calculo para o msm CEP e produtos.
				Frete frete = _cookieFrete.Consultar().Where(a => a.CEP == cepDestino && a.CodigoCarrinho == GerarHash(_cookieCarrinhoCompra.Consultar())).FirstOrDefault();

				if (frete != null)
				{
					return Ok(frete);
				}
				else
				{



					List<ProdutoItem> produtos = CarregarProdutoDB();
					List<Pacote> pacotes = _calcularPacote.CalcularPacotesDeProdutos(produtos);

					ValorPrazoFrete valorPAC = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.PAC, pacotes);
					ValorPrazoFrete valorSEDEX = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX, pacotes);
					ValorPrazoFrete valorSEDEX10 = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX10, pacotes);

					List<ValorPrazoFrete> lista = new List<ValorPrazoFrete>();

					if (valorPAC != null) lista.Add(valorPAC);
					if (valorSEDEX != null) lista.Add(valorSEDEX);
					if (valorSEDEX10 != null) lista.Add(valorSEDEX10);

					frete = new Frete()
					{
						CEP = cepDestino,
						CodigoCarrinho = GerarHash(_cookieCarrinhoCompra.Consultar()),
						ListaValores = lista
					};

					_cookieFrete.Cadastrar(frete);

					return Ok(frete);
				}
			}
			catch (Exception e)
			{
				_logger.LogError(e, "> CarrinhoCompraController - CalcularFrete");
				return BadRequest(e);
			}
		}
	}
}
