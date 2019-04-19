using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Contracts;

namespace Projeto1.Repositories
{
    interface ISetorRepository:IBaseRepository<Setor>
    {
        List<Setor> FindByName(string nome);
    }
}
