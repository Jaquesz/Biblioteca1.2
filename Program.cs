using System;
using System.Collections;
using System.Collections.Generic;


namespace Biblioteca;

class Program
{
	public static void Main(string[] args)
	{
		Biblioteca biblioteca= new Biblioteca();

		int op=1;

		while(op!=0) {

		
		
		Console.WriteLine("Escolha uma das opções!");
		Console.WriteLine("1- Cadastrar usuário.");
		Console.WriteLine("2- Emprestar livro.");
		Console.WriteLine("3- Devolver livro."); 
		Console.WriteLine("4- Consultar empréstimos ativos.");
		Console.WriteLine("5- Cadastrar Funcionário. ");
		Console.WriteLine("6- Listar Funcionários.");
		Console.WriteLine("7- Sair.");

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
				Console.Clear();
				Console.WriteLine("Digite o id do cliente: ");
				int idcliente = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Digite o id do livro: ");
				int idlivro = Int32.Parse(Console.ReadLine());

				DateTime dataemprestimo = DateTime.Now;

				DateTime devolucaoprevista = DateTime.Now.AddDays(15);

				Biblioteca.EmprestarLivro(idcliente, idlivro, dataemprestimo, devolucaoprevista);

			}

			else if(op==3)
			{
				Console.Clear();
				Console.WriteLine("Digite o id do cliente: ");
				int idcliente = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Digite o id do livro: ");
				int idlivro = Int32.Parse(Console.ReadLine());

				Biblioteca.DevolverLivro(idcliente, idlivro);
			}

			else if(op==4)
			{
				Console.Clear();

				Biblioteca.Consultar();
			}

			else if (op==5)
			{
				Console.Clear();
				Console.WriteLine("Digite seu nome.");
				string nome = Console.ReadLine();

				Console.WriteLine("Digite o seu cargo: ");
				string cargo = Console.ReadLine();

				Console.WriteLine("Data da admissão: ");
				DateTime dataadmissao = DateTime.Parse(Console.ReadLine());

				Console.WriteLine("Sua data de nascimento: ");
				DateTime datanascimento = DateTime.Parse(Console.ReadLine());

				Funcionario.CadastrarNovoFuncionario(nome, cargo, dataadmissao, datanascimento);
			}
		
			else if (op==6)
			{
				Console.Clear();

				Funcionario.Listar();
			}

			else if (op==7)
			{
				Console.WriteLine("Finalizando o programa.");
				break;
			}

		}




		}

	

}
