using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Projeto1.Entities;
using Projeto1.DAL_;


namespace Projeto1.BLL
{
    public class FuncionarioBusiness
    {
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            repository.Insert(funcionario);
        }
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            repository.Update(funcionario);
        }
        public void ExcluirFuncionario(int Id)
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            repository.Delete(Id);
        }
        public List<Funcionario> BuscarTodosFuncionarios()
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            return repository.FindAll();
        }

        public List<Funcionario> BuscarTodosFuncionarioPorNome(string nome)
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            return repository.FindByName("%"+nome+"%");
        }

        public Funcionario BuscarTodosFuncionariosPorId(int Id)
        {
            FuncionarioRepository repository = new FuncionarioRepository();
            return repository.FindById(Id);
        }

    }
}
