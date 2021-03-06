using LojaVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
	public class GerenciarEmail
	{
		private readonly SmtpClient _smtp;
		private readonly IConfiguration _configuration;
		public GerenciarEmail(SmtpClient smtp, IConfiguration configuration)
		{ 
			_smtp = smtp;
			_configuration = configuration;
		}

		public void EnviarContatoPorEmail(Contato contato)
		{
			//SMTP -> Servidor q vai enviar a mensagem.
			
			var corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
				"<b>Nome: </b> {0} <br />" +
				"<b>Email: </b> {1} <br />" +
				"<b>Texto: </b> {2} <br />" +
				"<br /> E-mail enviado automaticamente do site LojaVirtual.",
				contato.Nome,
				contato.Email,
				contato.Texto
				);

			//MailMessage -> Construir a mensagem.
			MailMessage mensagem = new MailMessage();
			mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:Username"));
			mensagem.To.Add("paulocraazy@gmail.com");
			mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
			mensagem.Body = corpoMsg;
			mensagem.IsBodyHtml = true;

			//Enviar mensagem via SMTP
			_smtp.Send(mensagem);
		}

		public void EnviarSenhaParaColaboradorPorEmail(Colaborador colaborador)
		{
			var corpoMsg = string.Format("<h2>Colaborador - LojaVirtual</h2>" +
				"Sua senha é: " +
				"<h3>{0}</h3>", colaborador.Senha);

			//MailMessage -> Construir a mensagem.
			MailMessage mensagem = new MailMessage();
			mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:Username"));
			mensagem.To.Add(colaborador.Email);
			mensagem.Subject = "Colaborador - LojaVirtual - E-mail: " + colaborador.Nome;
			mensagem.Body = corpoMsg;
			mensagem.IsBodyHtml = true;

			//Enviar mensagem via SMTP
			_smtp.Send(mensagem);
		}

		public void EnviarDadosDoPedido(Cliente cliente, Pedido pedido)
		{
			//SMTP -> Servidor q vai enviar a mensagem.

			var corpoMsg = string.Format(				
				"<h1>Pedido realizado com sucesso!</h1><br />" +
				"<h3> N° pedido: {0} </h3>" +
				"<br /> Faça o login em nossa loja virtual e acompanhe o andamento.",
				pedido.Id + "/" + pedido.TransactionId
			);

			//MailMessage -> Construir a mensagem.
			MailMessage mensagem = new MailMessage();
			mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:Username"));
			mensagem.To.Add(cliente.Email);
			mensagem.Subject = "LojaVirtual - Pedido " + "(" + pedido.Id + "/" + pedido.TransactionId + ")";
			mensagem.Body = corpoMsg;
			mensagem.IsBodyHtml = true;

			//Enviar mensagem via SMTP
			_smtp.Send(mensagem);
		}
	}
}
