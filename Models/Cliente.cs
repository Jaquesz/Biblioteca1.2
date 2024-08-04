using System;
using System.Collections.Generic;
using System.Data.Common;
using Biblioteca;
using Microsoft.VisualBasic;

namespace Biblioteca;

public class Cliente : Pessoa
{

	public static  List<Cliente> clientes = new List<Cliente>

    {
	new Cliente  {Id= 1, Nome= "Jaqueline", DataNascimento = new DateTime(2003,11,20), Telefone = "42 99999999", Email = "jaqueline@gmail.com"},
	new Cliente  {Id= 2, Nome= "Lucas momo", DataNascimento = new DateTime(2004,06,01), Telefone = "42 99999998", Email = "lucasmomo@gmail.com"}
	};
		public static void CadastrarNovoCliente(string nome, DateTime dataNascimento, string email, string telefone)
	{	

		int novoId = clientes.Count > 0 ? clientes[^1].Id + 1 : 1;
		Cliente novoCliente = new Cliente
		{
			Id = novoId,
			Nome = nome,
			DataNascimento = dataNascimento,
			Email = email,
			Telefone = telefone
		};
		clientes.Add( novoCliente);
		Console.WriteLine("Seu cadastro foi realizado com sucesso!!");
	}

public static void Verificar(int idCliente){

var cliente =clientes.FirstOrDefault(cliente => cliente.Id == idCliente);}
    public int Id { get; set; }
	public string Telefone { get; set;}

	public string Email { get; set;}
} 