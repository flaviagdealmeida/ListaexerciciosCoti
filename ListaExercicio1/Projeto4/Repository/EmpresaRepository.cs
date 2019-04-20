using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto4.Entity;

namespace Projeto4.Repository
{
    public class EmpresaRepository
    {
        public void ExportarParaTxt(Empresa empresa)
        {
            using (StreamWriter streamWriter = new StreamWriter($"c:\\Temp\\c#\\empresas.txt", true))
            {
                string dados = $"CÓDIGO DA EMPRESA: {empresa.Id}\t " +
                    $"NOME DA EMPRESA: {empresa.Nome}\t " +
                    $"CNPJ:{empresa.Cnpj}\t " +
                    $"LOGRADOURO: {empresa.Endereco.Logradouro}\t" +
                    $"NUMERO: {empresa.Endereco.Numero}\t" +
                    $"BAIRRO: {empresa.Endereco.Bairro}\t" +
                    $"CIDADE: {empresa.Endereco.Cidade}\t" +
                    $"ESTADO: {empresa.Endereco.Estado}\t" +
                    $"CEP: {empresa.Endereco.Cep}" +
                    $"CONTATO TELEFONE FIXO: {empresa.Contato.Fixo}" +
                    $"CONTATO TELEFONE CEL: {empresa.Contato.Celular}" +
                    $"CONTATO TELEFONE EMAIL: {empresa.Contato.Email}";


                streamWriter.WriteLine(dados);
            }



        }

        public void ExibirTela(Empresa empresa)
        {
            string dados = $"CÓDIGO DA EMPRESA: {empresa.Id}\t " +
                    $"\nNOME DA EMPRESA................: {empresa.Nome}\t " +
                    $"\nCNPJ ..........................: {empresa.Cnpj}\t " +
                    $"\nLOGRADOURO ....................: {empresa.Endereco.Logradouro}\t" +
                    $"\nNUMERO ........................: {empresa.Endereco.Numero}\t" +
                    $"\nBAIRRO ........................: {empresa.Endereco.Bairro}\t" +
                    $"\nCIDADE ........................: {empresa.Endereco.Cidade}\t" +
                    $"\nESTADO ........................: {empresa.Endereco.Estado}\t" +
                    $"\nCEP ...........................: {empresa.Endereco.Cep} \t" +
                    $"\nCONTATO TELEFONE FIXO .........: {empresa.Contato.Fixo} \t" +
                    $"\nCONTATO TELEFONE CEL ..........: {empresa.Contato.Celular} \t" +
                    $"\nCONTATO TELEFONE EMAIL ........: {empresa.Contato.Email}\t";

            Console.WriteLine(dados);
        }
    }
}
