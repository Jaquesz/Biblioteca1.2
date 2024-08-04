using System;
using System.Collections.Generic;
namespace Biblioteca;

public class Emprestimo : Livro
{
	public int Id { get; set; }
	public int IdCliente { get; set; }
	public int IdLivro { get; set; }
	public DateTime DataDoEmprestimo { get; set; }
	public DateTime DataDevolucaoPrevista { get; set; }
	public DateTime? DataDevolucao { get; set; } // atributo opicional, que pode ser nulo

    public override string ToString()
    {
        return $"Id cliente: {IdCliente}, Id do livro: {IdLivro}, Data do empréstimo: {DataDoEmprestimo.ToShortDateString()}, Data de devolução prevista: {DataDevolucaoPrevista.ToShortDateString()}"; 
    }
}