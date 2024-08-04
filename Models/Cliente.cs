using System;
using System.Collections.Generic;
using System.Data.Common;
using Biblioteca;
using Microsoft.VisualBasic;

namespace Biblioteca;

public class Cliente : Pessoa
{

 public int IdCliente { get; set; }
	public string Telefone { get; set;}

	public string Email { get; set;}
	public static  List<Cliente> clientes = new List<Cliente>

    {
	new Cliente  {IdCliente= 1, Nome= "Jaqueline", DataNascimento = new DateTime(2003,11,20), Telefone = "42 99999999", Email = "jaqueline@gmail.com"},
	new Cliente  {IdCliente= 2, Nome= "Lucas momo", DataNascimento = new DateTime(2004,06,01), Telefone = "42 99999998", Email = "lucasmomo@gmail.com"}
	};
		public static void CadastrarNovoCliente(string nome, DateTime dataNascimento, string email, string telefone)
	{	

		int novoId = clientes.Count > 0 ? clientes[^1].IdCliente + 1 : 1;
		Cliente novoCliente = new Cliente
		{
			IdCliente = novoId,
			Nome = nome,
			DataNascimento = dataNascimento,
			Email = email,
			Telefone = telefone
		};
		clientes.Add( novoCliente);
		Console.WriteLine("Seu cadastro foi realizado com sucesso!!");
	}


   
} 