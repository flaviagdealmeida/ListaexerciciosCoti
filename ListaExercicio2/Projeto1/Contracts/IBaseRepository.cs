using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Contracts
{
    interface IBaseRepository<T> where T:class
    {

        void Insert(T obj);
        void Update(T obj);
        void Delete(int Id);
        List<T>FindAll();
        T FindByID(int Id);

    }
}
