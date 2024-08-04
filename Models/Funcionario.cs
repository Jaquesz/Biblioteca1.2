using System;

namespace Biblioteca;

public class Funcionario : Pessoa
{
	public int Id { get; set; }
	public string Cargo{ get; set; }
	public DateTime DataAdmissao { get; set; } 

	public static List<Funcionario> funcionarios = new List<Funcionario>();

	public static void CadastrarNovoFuncionario(string nome, string cargo, DateTime dataadmissao, DateTime datanascimento)
	{
		int idfuncionario = funcionarios.Count > 0 ? funcionarios[^1].Id + 1 : 1;
		Funcionario novofuncionario = new Funcionario()
		{
			Id = idfuncionario,
			Nome = nome,
			Cargo = cargo,
			DataAdmissao = dataadmissao,
			DataNascimento = datanascimento 
		};

		funcionarios.Add(novofuncionario);
		Console.WriteLine("Funcionário cadastrado com sucesso. ");
	}

	public static void Listar()
	{
		Console.WriteLine("Estes são os funcionários cadastrados: ");

		if (funcionarios.Count == 0)
		{
			Console.WriteLine("Nenhum funcionário encontrado. ");
		}

		else 
		{
			foreach (var func in funcionarios)
			{
				Console.WriteLine(func.ToString());
			}
		}
	}

	public override string ToString()
	{
		return $"Nome funcionario: {Nome}, Cargo : {Cargo}, Data da admissão: {DataAdmissao.ToShortDateString()}, Data de nascimento: {DataNascimento.ToShortDateString()}"; 
	}
}

