namespace Biblioteca;

class Program
{
	public static void Main(string[] args)
	{
		Biblioteca biblioteca= new Biblioteca();
		
		// adicionar cliente
		biblioteca.clientes.Add(new Cliente{Id = 1, Nome = "Jorge e Mateus", 
		DataNascimento = new DateTime(1980, 01, 01), Telefone = "62999999"});
		
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


		}

		switch(op) 
		
		{

			case 1:

				CadastrarNovoCliente();
				
				break;

			case 2: 

				EmprestarLivro();

				break;

			case 3:

				DevolverLivro();

				break;	

			case 4:

				DataDevolucao();

				break;

			case 5:

				Multa();

				break;

			case 6:

				Sair();

				break;				

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
