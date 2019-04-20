using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entity;
using Projeto1.Repository;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();
            produto.Categoria = new Categoria();


            Console.WriteLine(".:: CADASTRO DE PRODUTOS ::.");
            Console.Write("Informe ID do Produto: .................\t");
            produto.IdProduto = int.Parse(Console.ReadLine());

            Console.Write("Informe Nome do Produto: ...............\t");
            produto.Nome = Console.ReadLine();

            Console.Write("Informe Preço do Produto: ..............\t");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("Informe Validade do Produto: ......;;...\t");
            produto.DataValidade = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe Id da Categoria do Produto: .....\t");
            produto.Categoria.IdCategoria = int.Parse(Console.ReadLine());

            Console.Write("Informe Descrição da Categoria ..........\t");
            produto.Categoria.Descricao = Console.ReadLine();

            try
            {
                ProdutoRepository produtoRepository = new ProdutoRepository();
                produtoRepository.ExportarParaTxt(produto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na gravação dos dados" + e.Message);
                throw;
            }

        }
    }
}
