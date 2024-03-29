﻿using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories.Contracts
{
	public interface IImagemRepository
	{
		void Cadastrar(Imagem imagem);
		void Excluir(int Id);
		void ExcluirImagensDoProduto(int ProdutoId);
		void CadastrarImagens(List<Imagem> ListaImagens, int ProdutoId);
	}
}
