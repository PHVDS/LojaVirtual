﻿using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
	[Area("Colaborador")]
	[ColaboradorAutorizacao]
	public class CategoriaController : Controller
	{
		private readonly ICategoriaRepository _categoriaRepository;
		private readonly IProdutoRepository _produtoRepository;

		public CategoriaController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
		{
			_categoriaRepository = categoriaRepository;
			_produtoRepository = produtoRepository;
		}

		public IActionResult Index(int? pagina)
		{
			var categorias = _categoriaRepository.ObterTodasCategorias(pagina);

			return View(categorias);
		}

		[HttpGet]
		public IActionResult Cadastrar()
		{
			ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar([FromForm]Categoria categoria)
		{
			if (ModelState.IsValid)
			{
				_categoriaRepository.Cadastrar(categoria);

				TempData["MSG_S"] = Mensagem.MSG_S001;

				return RedirectToAction(nameof(Index));
			}

			ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
			return View();
		}

		[HttpGet]
		public IActionResult Atualizar(int id)
		{
			var categoria = _categoriaRepository.ObterCategoria(id);

			ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Where(a => a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
			
			return View(categoria);
		}

		[HttpPost]
		public IActionResult Atualizar([FromForm] Categoria categoria, int id)
		{
			if (ModelState.IsValid)
			{
				_categoriaRepository.Atualizar(categoria);

				TempData["MSG_S"] = Mensagem.MSG_S001;

				return RedirectToAction(nameof(Index));
			}
			ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Where(a => a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
			return View();
		}

		[HttpGet]
		[ValidateHttpReferer]
		public IActionResult Excluir(int id)
		{
			var categoriaFilho = _categoriaRepository.ObterCategoriasPorCategoriaPai(id);
			if (categoriaFilho.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();

				foreach (var item in categoriaFilho)
				{
					stringBuilder.Append($"'{item.Nome}' ");
				}
                TempData["MSG_E"] = string.Format(Mensagem.MSG_E012, stringBuilder.ToString());
                return RedirectToAction(nameof(Index));
            }

            var produtoFilho = _produtoRepository.ObterProdutoPorCategoria(id);
            if (produtoFilho.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var item in produtoFilho)
                {
                    stringBuilder.Append($"'{item.Nome}' ");
                }
                TempData["MSG_E"] = string.Format(Mensagem.MSG_E013, stringBuilder.ToString());
                return RedirectToAction(nameof(Index));
            }

				_categoriaRepository.Excluir(id);
				TempData["MSG_S"] = Mensagem.MSG_S002;
				return RedirectToAction(nameof(Index));
		}
	}
}
