﻿using LojaVirtual.Libraries.Json.Resolver;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
	public class PedidoController : Controller
	{
		private readonly IPedidoRepository _pedidoRepository;

		public PedidoController(IPedidoRepository pedidoRepository) 
		{
			_pedidoRepository = pedidoRepository;
		}
		public IActionResult Index(int id)
		{
			Pedido pedido = _pedidoRepository.ObterPedido(id);

			ViewBag.Produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(
				pedido.DadosProdutos,
					new JsonSerializerSettings()
					{ 
						ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>()
					}
				);

			return View(pedido);
		}
	}
}
