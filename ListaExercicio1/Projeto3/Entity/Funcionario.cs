using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3.Entity
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public List<Dependentes> Dependentes { get; set; }


    }
}
