using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class Class1
    {

        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }


        public Class1()
        {

        }

        public Class1(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public override string ToString()
        {
            return $"Id Funcionario: {IdFuncionario}, Nome: {Nome}, Salario: {Salario}, Data dde Admissão: {DataAdmissao}";
        } 
    }
}
