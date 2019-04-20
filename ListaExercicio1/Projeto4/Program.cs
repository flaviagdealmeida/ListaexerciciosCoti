using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4.Entity;
using Projeto4.Repository;

namespace Projeto4
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa empresa = new Empresa();
            empresa.Endereco = new Endereco();
            empresa.Contato = new Contato();
            EmpresaRepository empresaRepository = new EmpresaRepository();




            Console.WriteLine("CADASTRO DE EMPRESA \n");


            Console.Write("Informe Id do empresa: .............\t");
            empresa.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe Nome do empresa: ...........\t");
            empresa.Nome = Console.ReadLine();

            Console.Write("Informe CNPJ do empresa: ...........\t");
            empresa.Cnpj = Console.ReadLine();

            Console.Write("Informe Id do Endereço: ............\t");
            empresa.Endereco.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe Logradouro: ................\t");
            empresa.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe Numero: ....................\t");
            empresa.Endereco.Numero = Console.ReadLine();

            Console.Write("Informe Bairro: ....................\t");
            empresa.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe Cidade: ....................\t");
            empresa.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe Estado: ....................\t");
            empresa.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe CEP: .......................\t");
            empresa.Endereco.Cep = Console.ReadLine();

            Console.Write("Informe Telefone Fixo: .............\t");
            empresa.Contato.Fixo = Console.ReadLine();

            Console.Write("Informe Telefone Celular: ..........\t");
            empresa.Contato.Celular = Console.ReadLine();

            Console.Write("Informe Email: .....................\t");
            empresa.Contato.Email = Console.ReadLine();

            empresaRepository.ExibirTela(empresa);

            try
            {
                empresaRepository.ExportarParaTxt(empresa);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na gravaçao" + e.Message);

            }

            Console.ReadKey();
        }
    }
}
