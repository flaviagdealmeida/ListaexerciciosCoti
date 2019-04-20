using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Projeto3.Entity;

namespace Projeto3.Repository
{
   public class FuncionarioRepository
    {


        public void ExportarParaJson(Funcionario funcionario)
        {
            using (StreamWriter streamWriter = new StreamWriter("c:\\Temp\\c#\\funcionariosedependentes.json"))
            {
                string dados = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
                streamWriter.WriteLine(dados);
            }
        }
    }
}
