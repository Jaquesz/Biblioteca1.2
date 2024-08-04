using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Biblioteca;

public class Biblioteca
{
	public List<Cliente> clientes = new List<Cliente>();
	public List<Livro> livros= new List<Livro>();
	public static List<Emprestimo> emprestimos= new List<Emprestimo>();
	
	public static void EmprestarLivro(int idcliente, int idlivro, DateTime dataemprestimo, DateTime devolucaoprevista)
	{
		
		Emprestimo NovoEmprestimo = new Emprestimo()
		{
			IdCliente = idcliente,
			IdLivro = idlivro,
			DataDoEmprestimo = dataemprestimo,
			DataDevolucaoPrevista = devolucaoprevista

		};

		emprestimos.Add(NovoEmprestimo);
		Console.WriteLine("Empréstimo feito com sucesso ");
		
	}
	
	public static void DevolverLivro(int idcliente, int idlivro)
	{
		var Devolver = emprestimos.FirstOrDefault(e => e.IdCliente == idcliente && e.IdLivro == idlivro);
		
		if (emprestimos == null)
		{
			Console.WriteLine("Livro não encontrado"); 
			return;
		}
		
		emprestimos.Remove(Devolver);

		Console.WriteLine("Livro Devolvido com sucesso.");
	}

	public static void Consultar()
	{
		Console.WriteLine("Estes são os empréstimos ativos: ");

		if (emprestimos.Count == 0)
		{
			Console.WriteLine("Nenhum empréstimo encontrado. ");
		}

		else 
		{
			foreach (var emp in emprestimos)
			{
				Console.WriteLine(emp.ToString());
			}
		}
	}

}