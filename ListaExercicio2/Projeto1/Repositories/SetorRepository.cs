using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Projeto1.Repositories 
{
    class SetorRepository : ISetorRepository
    {

        private SqlConnection conn;
        private string connectionString;

        public SetorRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["exercicio2"].ConnectionString;
        }
        public void Delete(int Id)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "Delete from Setor where IdSetor = @IdSetor";
                conn.Execute(query, new {IdSetor = Id});
            }
        }

        public List<Setor> FindAll()
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "select * from Setor";
                return conn.Query<Setor>(query).ToList();
            }
        }

        public Setor FindByID(int id)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "select * from Setor where IdSetor = @IdSetor";
                return conn.QuerySingleOrDefault<Setor>(query, new { IdSetor = id });
            }
        }

        public List<Setor> FindByName(string nome)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "select * from Setor where Nome = @Nome";
                return conn.Query<Setor>(query, new { Nome = nome}).ToList();
            }
            
        }

        public void Insert(Setor setor)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "insert into Setor (Nome,Descricao) values (@Nome, @Descricao)";
                conn.Execute(query, setor);
            }
        }

        public void Update(Setor setor)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string query = "update Setor set Nome = @Nome,Descricao=@Descricao where IdSetor = @IdSetor ";
                conn.Execute(query, setor);
            } 
        }
    }
}
