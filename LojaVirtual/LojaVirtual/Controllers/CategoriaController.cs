﻿using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Controllers
{
	[Area("Colaborador")]
	//[ColaboradorAutorizacao]
	public class CategoriaController : Controller
	{
		private readonly ICategoriaRepository _categoriaRepository;

		public CategoriaController(ICategoriaRepository categoriaRepository)
		{
			_categoriaRepository = categoriaRepository;
		}

		public IActionResult Index(int? pagina)
		{
			var categorias = _categoriaRepository.ObterTodasCategorias(pagina);

			return View(categorias);
		}

		[HttpGet]
		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar([FromForm]Categoria categoria)
		{
			return View();
		}

		[HttpGet]
		public IActionResult Atualizar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Atualizar([FromForm] Categoria categoria)
		{
			return View();
		}

		[HttpGet]
		public IActionResult Excluir()
		{
			return View();
		}
	}
}
