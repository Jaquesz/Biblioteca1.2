using System;

namespace Biblioteca;

public class Livro
{
	public int Id { get; set; }
	public string Titulo { get; set; }	
	public string Autor {get; set; }
	public bool Disponivel{ get; set; }


public static  List<Livro> livros = new List<Livro>

    {
	new Livro  {Id= 1, Titulo = "Pai rico pai pobre", Autor = "Robert Kayosaki", Disponivel = true},
	new Livro  {Id= 2, Titulo = "Quem é você, Alaska?", Autor = "John Green", Disponivel = false},
	new Livro  {Id= 3, Titulo = "O pequeno príncipe", Autor = "Antoine de Saint-Exupéry", Disponivel = true},
	new Livro  {Id= 4, Titulo = "Mil beijos de garoto", Autor = "Tillie Cole", Disponivel = true},
	new Livro  {Id= 5, Titulo = "É assim que acaba", Autor = "Colleen Hoover", Disponivel = true} 
	};



} 


