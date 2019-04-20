using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto2.Entity;
using Projeto2.Repository;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Endereco = new Endereco();

            ClienteRepository clienteRepository = new ClienteRepository();
            Console.WriteLine(".:: CADASTRO DE CLIENTE ::.");

            Console.Write("Informe Id do cliente: .............\t");
            cliente.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe Nome do cliente: ...........\t");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe CPF do cliente: ............\t");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Informe Id do Endereço: ............\t");
            cliente.Endereco.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe Logradouro: ................\t");
            cliente.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe Bairro: ....................\t");
            cliente.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe Cidade: ....................\t");
            cliente.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe Estado: ....................\t");
            cliente.Endereco.Estado = Console.ReadLine();
            
            Console.Write("Informe CEP: .......................\t");
            cliente.Endereco.Cep = Console.ReadLine();

            try
            {
                clienteRepository.ExportarParaTxt(cliente);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na gravaçao" + e.Message);
                
            }


        }
    }
}
