using System; 
using System.Collections.Generic;


namespace Biblioteca;

class Program
{
	public static void Main(string[] args)
	{
		Biblioteca biblioteca= new Biblioteca();
		
		// adicionar cliente
		
		
		// adicionar livro
		biblioteca.livros.Add(new Livro{Id = 1, Titulo ="Dom Casmurro", 
		Autor = "Machado de Assis", Disponivel = true});
		
		// Emprestar livro
		biblioteca.EmprestarLivro(1, 1);
		biblioteca.DevolverLivro(1, 1);
		biblioteca.EmprestarLivro(1, 2);
		
		/*static void IniciarBiblioteca(Biblioteca biblioteca)
		{
			biblioteca.EmprestarLivro(2,2);
		}*/

		int op=1;

		while(op!=0) {

		
		
		Console.WriteLine("Escolha uma das opções!");
		Console.WriteLine("1- Cadastrar usuário.");
		Console.WriteLine("2- Emprestar livro.");
		Console.WriteLine("3- Devolver livro."); 
		Console.WriteLine("4- Consultar data de devolução.");
		Console.WriteLine("5- Consultar multa por atraso.");
		Console.WriteLine("6- Sair.");

		op= int.Parse(Console.ReadLine());

		if(op==1)
		{ 		Console.Clear();
				Console.WriteLine("Digite seu nome.");
				string nome = Console.ReadLine();
				Console.WriteLine("Digite sua data de nascimento (no formato Ano, mês e dia).");
				DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
				Console.WriteLine("Digite seu email.");
				string email = Console.ReadLine();
				Console.WriteLine("Digite seu telefone.");
				string telefone = Console.ReadLine();
				Cliente.CadastrarNovoCliente(nome, dataNascimento, email, telefone);
				

		} 
		
			else if(op==2)
			{
				EmprestarLivro();
			}

		

		}



		}

		
    public static void CadastrarNovoCliente()
    {
        
		Console.WriteLine("Usuário cadastrado com sucesso!");

    }

	private static void EmprestarLivro()
	{
		Console.WriteLine("Livro emprestado com sucesso!");
	}

	private static void DevolverLivro()
	{
		Console.WriteLine("Livro devolvido com sucesso!");
	}

	private static void DataDevolucao()
	{
		Console.WriteLine("Devolução daqui a 15 dias!");
	}

	private static void Multa()
	{
		Console.WriteLine("A multa por atraso é de 1 mês sem poder fazer emprestimos ");
	}

	private static void Sair()
	{
		Console.WriteLine("Saindo...");
	}

}
