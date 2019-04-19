using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Setor Setor { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, DateTime dataAdmissao, Setor Setor)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            DataAdmissao = dataAdmissao;
            this.Setor = Setor;
        }

        public override string ToString()
        {
            return $"Id Funcionario: {IdFuncionario}, Nome do Funcionario: {Nome}, Data Admissão: {DataAdmissao}";
        }
    }
}
