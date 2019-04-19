using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Setor
    {

        public int IdSetor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> funcionarios { get; set; }


        public Setor()
        {

        }

        public Setor(int idSetor, string nome, string descricao, List<Funcionario> funcionarios)
        {
            IdSetor = idSetor;
            Nome = nome;
            Descricao = descricao;
            this.funcionarios = funcionarios;
        }


        public override string ToString()
        {
            return $"Id Setor: {IdSetor}, Nome do Setor: {Nome}, Descrição: {Descricao}";
        }

    }
}
