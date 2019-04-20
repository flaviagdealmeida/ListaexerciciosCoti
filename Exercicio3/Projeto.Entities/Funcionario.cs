using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }


        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public override string ToString()
        {
            return $"Id Funcionario: {IdFuncionario}, Nome: {Nome}, Salario: {Salario}, Admissao: {DataAdmissao}";
        }
    }
}
