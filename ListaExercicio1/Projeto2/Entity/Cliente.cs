using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entity
{
    public class Cliente:Pessoa
    {
        public string Cpf { get; set; }

        public Endereco Endereco { get; set; }

    }
}
