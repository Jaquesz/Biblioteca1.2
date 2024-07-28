using System;

namespace Biblioteca;

public class Cliente : Pessoa
{

	private List<Cliente> clientes = new List<Cliente>();

	public void CadastrarNovoCliente(string Nome, string Email, string Telefone, int Id)
	{
		Cliente.Add(new Cliente());
		{
			Nome = Nome;
			Email = Email;
			Id = Id++;
			Telefone = Telefone;

		};
	}

    private static void Add(Cliente cliente)
    {
        Cliente.Add(cliente);
    }

    public int Id { get; set; }
	public string Telefone { get; set;}

	public string Email { get; set;}
} 