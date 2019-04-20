using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using Projeto1.Entities_;


namespace Projeto1.DAL_
{
    public class FuncionarioRepository
    {
        private string connectionString;

        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["exercicio3"].ConnectionString;
        }


        public void Insert(Funcionario funcionario)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "Insert into Funcionario (Nome, Salario, DataAdmissao) values (@Nome, @Salario, @DataAdmissao)";
                conn.Execute(query, funcionario);
            }


        }

        public void Update(Funcionario funcionario)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "Update Funcionario set Nome = @Nome, Salario = @Salario, DataAdmissao = @DataAdmissao where IdFuncionario = @IdFuncionario";
                conn.Execute(query, funcionario);
            }


        }

        public void Delete(int Id)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "Delete Funcionario where IdFuncionario = @IdFuncionario";
                conn.Execute(query, new { IdFuncionario = Id });
            }


        }

        public List<Funcionario> FindAll()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "select * from Funcionario";
                return conn.Query<Funcionario>(query).ToList();
            }


        }

        public Funcionario FindById(int Id)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "select * from Funcionario where IdFuncionario = @IdFuncionario";
                return conn.QuerySingleOrDefault<Funcionario>(query, new { IdFuncionario = Id });
            }


        }

        public List<Funcionario> FindByName(string nome)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "select * from Funcionario where Nome Like @Nome";
                return conn.Query<Funcionario>(query).ToList();
            }


        }

    }
}
