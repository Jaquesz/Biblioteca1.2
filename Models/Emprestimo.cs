using System;
using System.Collections.Generic;
namespace Biblioteca;

public class Emprestimo : Livro
{
	public int Id { get; set; }
	public Cliente ClienteEmprestimo { get; set; }
	public Livro LivroEmprestado { get; set; }
	public DateTime DataDoEmprestimo { get; set; }
	public DateTime DataDevolucaoPrevista { get; set; }
	public DateTime? DataDevolucao { get; set; } // atributo opicional, que pode ser nulo
	
	public bool Devolvido
	{
		get
		{
			return DataDevolucao != null; 
		}
	}	

    public static void EmprestarLivro(int idCliente, int idLivro)
	{
		Cliente.Verificar(idCliente);
		var Livro = livros.FirstOrDefault(livro => livro.Id == idLivro);
		

	}

}