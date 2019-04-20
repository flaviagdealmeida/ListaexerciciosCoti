using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto1.Entity;

namespace Projeto1.Repository
{
    public class ProdutoRepository
    {

        public void ExportarParaTxt(Produto produto)
        {
            using (StreamWriter streamWriter = new StreamWriter($"c:\\Temp\\c#\\produtos.txt", true))
            {
                string dados = $"Id: {produto.IdProduto} \t Nome: {produto.Nome}\t Preço:{produto.Preco.ToString("n2")}\t Validade: {produto.DataValidade.ToString("MM/yyyy")}\t Categoria: {produto.Categoria.Descricao}";
                streamWriter.WriteLine(dados);
            }
        }
    }
}
