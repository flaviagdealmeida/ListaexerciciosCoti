using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Repositories;
namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("\n - SISTEMA DE GESTÂO DE PESSOAL - \n");
                Console.WriteLine("(1) Gerenciar Funcionários");
                Console.WriteLine("(2) Gerenciar Setores");

                Console.Write("\nEscolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExecutarMenuFuncionarios();
                        break;
                    case 2:
                        ExecutarMenuSetor();
                        break;
                }

                ExecutarRecursividade(args);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        private static void ExecutarRecursividade(string[] args)
        {
            Console.Write("\nDeseja realizar outra operação? (S,N): ");
            string escolha = Console.ReadLine();

            if (escolha.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Bye!");
            }

        }

        private static void ExecutarMenuSetor()
        {
            Console.WriteLine("\n - CONTROLE DE SETORES - \n");

            Console.WriteLine("(1) Cadastrar Setor");
            Console.WriteLine("(2) Atualizar Setor");
            Console.WriteLine("(3) Excluir Setor");
            Console.WriteLine("(4) Consultar todos os Setores");
            Console.WriteLine("(5) Consultar Setor por ID");
            Console.WriteLine("(6) Consultar Setor por Nome");

            SetorRepository repository = new SetorRepository();
            Setor setor = new Setor();
            try
            {
                Console.Write("\nInforme a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                int id;
                switch (opcao)
                {
                    case 1:
                        LerSetor(setor);
                        repository.Insert(setor);
                        break;
                    case 2:
                        LerSetor(setor);
                        Console.WriteLine("Id do Setor");
                        setor.IdSetor =Convert.ToInt16(Console.ReadLine());
                        repository.Update(setor);
                        break;
                    case 3:
                        Console.WriteLine("Id do Setor");
                        id = Convert.ToInt16(Console.ReadLine());
                        repository.Delete(id);
                        break;
                    case 4:
                        foreach (Setor lsetores in repository.FindAll())
                            ExibirSetor(lsetores);
                     break;
                    case 5:
                        Console.WriteLine("Informe id do Setor");
                        id = Convert.ToInt16(Console.ReadLine());
                        Setor setores = repository.FindByID(id);
                            if(setores!=null)
                                ExibirSetor(setores);
                        break;
                    case 6:
                        string nome = Console.ReadLine();
                        foreach (Setor lsetores in repository.FindByName(nome))
                            ExibirSetor(lsetores);
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }

        private static void ExibirSetor(Setor setor)
        {
            Console.WriteLine("ID Setor ........ " + setor.IdSetor);
            Console.WriteLine("Nome Setor ..... " + setor.Nome);
            Console.WriteLine("Descrição ...... " + setor.Descricao);
        }

        private static void LerSetor(Setor setor)
        {
            Console.WriteLine("Informe Setor");
            setor.Nome = Console.ReadLine();

            Console.WriteLine("Informe Descricao");
            setor.Descricao = Console.ReadLine();
        }



        private static void ExecutarMenuFuncionarios()
        {
            Console.WriteLine("\n - CONTROLE DE FUNCIONÁRIOS - \n");

            Console.WriteLine("(1) Cadastrar Funcionário");
            Console.WriteLine("(2) Atualizar Funcionário");
            Console.WriteLine("(3) Excluir Funcionário");
            Console.WriteLine("(4) Consultar todos os Funcionários");
            Console.WriteLine("(5) Consultar Funcionário por ID");
            Console.WriteLine("(6) Consultar Funcionário por Nome");

            FuncionarioRepository repository = new FuncionarioRepository();
            Funcionario funcionario = new Funcionario();
            funcionario.Setor = new Setor();
            try
            {
                Console.Write("\nInforme a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        LerFuncionario(funcionario);
                        repository.Insert(funcionario);
                        break;
                    case 2:
                        LerFuncionario(funcionario);
                        Console.WriteLine("Id do Funcionario");
                        funcionario.IdFuncionario = Convert.ToInt16(Console.ReadLine());
                        repository.Update(funcionario);
                        break;
                    case 3:
                        Console.WriteLine("Id do Funcionario");
                        int id = Convert.ToInt16(Console.ReadLine());
                        repository.Delete(id);
                        break;
                    case 4:
                        foreach (Funcionario lfuncionarios in repository.FindAll())
                            ExibirFuncionario(lfuncionarios);
                        break;
                    case 5:
                        Console.WriteLine("Informe id do Funcionario");
                        id = Convert.ToInt16(Console.ReadLine());
                        Funcionario func= repository.FindByID(id);
                        if (func != null)
                            ExibirFuncionario(func);
                        break;
                    case 6:
                        Console.WriteLine("Informe Nome");
                        string nome ="%"+(Console.ReadLine()+"%");
                        foreach (Funcionario lfuncionarios in repository.FindByName(nome))
                            ExibirFuncionario(lfuncionarios);
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
        private static void ExibirFuncionario(Funcionario funcionario)
        {
            Console.WriteLine("ID Funcionario ........... " + funcionario.IdFuncionario);
            Console.WriteLine("Nome Funcionario ......... " + funcionario.Nome);
            Console.WriteLine("Admissao ................. " + funcionario.DataAdmissao);
            Console.WriteLine("Setor .................... " + funcionario.Setor.IdSetor);
            Console.WriteLine("Nome do Setor ............ " + funcionario.Setor.Nome);
            Console.WriteLine("Descrição Setor .......... " + funcionario.Setor.Descricao);

        }
        private static void LerFuncionario(Funcionario funcionario)
        {
            Console.WriteLine("Informe Nome do Funcionario");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe Data de Admissão");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe Setor");
            funcionario.Setor.IdSetor = int.Parse(Console.ReadLine());
     }

    }

}
