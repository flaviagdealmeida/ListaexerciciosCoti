using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3.Entity;
using Projeto3.Repository;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario();
            funcionario.Dependentes = new List<Dependentes>();


            Console.WriteLine(".:: CADASTRO DE FUNCIONARIOS E DEPENDENTES ::.");

            Console.Write("Informe a ID do Funcionario ...................\t");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nome do Funcionario .................\t");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe a Data de Admissao do Funcionario .....\t");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe S ou N para gravar dados de dependentes!");
            Console.WriteLine("Deseja gravar dependente? (S/N)");
            string resp = Console.ReadLine();
            do
            {

                Dependentes dependentes = new Dependentes();

                Console.Write("Informe a ID do Dependente ...................\t");
                dependentes.IdDependentes = int.Parse(Console.ReadLine());

                Console.Write("Informe o Nome do Dependente .................\t");
                dependentes.Nome = Console.ReadLine();

                Console.Write("Informe a Data de Nascimento do Dependente ...\t");
                dependentes.DataNascimento = DateTime.Parse(Console.ReadLine());

                funcionario.Dependentes.Add(dependentes);

                Console.WriteLine("Deseja gravar dependente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.Equals("S"));

            
            Console.Write("\nID: .............\t" + funcionario.IdFuncionario);
            Console.Write("\nNome: ...........\t" + funcionario.Nome);
            Console.WriteLine("\nAdmissao.: ..\t" + funcionario.DataAdmissao.ToString("dd/MM/yyyy") + "\n");
            Console.WriteLine(".:: DEPENDENTES ::.");

            foreach (var dependentesLista in funcionario.Dependentes)
            {
                Console.Write("\nID: .........\t"+dependentesLista.IdDependentes);
                Console.Write("\nNome: .......\t" + dependentesLista.Nome);
                Console.Write("\nNass.: ......\t" + dependentesLista.DataNascimento.ToString("dd/MM/yyyy")+"\n");
                Console.WriteLine("-----------------------------------------------");
            }


            try
            {
                FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.ExportarParaJson(funcionario);
            }
            catch (Exception e)
            {

                Console.WriteLine("Ocorreu um erro de gravação de dados"+e.Message); 
            }

            Console.ReadKey();



        }
    }
}
