using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto2.Entity;

namespace Projeto2.Repository
{
    public class ClienteRepository
    {

        public void ExportarParaTxt(Cliente cliente)
        {
            using (StreamWriter streamWriter = new StreamWriter($"c:\\Temp\\c#\\clientes.txt", true))
            {
                string dados = $"Id: {cliente.Id}\t " +
                    $"Nome: {cliente.Nome}\t " +
                    $"CPF:{cliente.Cpf}\t " +
                    $"Logradouro: {cliente.Endereco.Logradouro}\t" +
                    $"Bairro: {cliente.Endereco.Bairro}\t" +
                    $"Cidade: {cliente.Endereco.Cidade}\t" +
                    $"Estado: {cliente.Endereco.Estado}\t" +
                    $"Cep: {cliente.Endereco.Cep}";

                streamWriter.WriteLine(dados);
            }
        }

    }
}
