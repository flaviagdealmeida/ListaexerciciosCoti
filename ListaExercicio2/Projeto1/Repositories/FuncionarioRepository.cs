using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Projeto1.Repositories
{
    class FuncionarioRepository : IFuncionarioRepository
    {

        private SqlConnection conn;
        private string connectionString;
        private SqlCommand cmd;
        private SqlDataReader dr;


        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["exercicio2"].ConnectionString;
        }
        public void Delete(int Id)
        {
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                cmd = new SqlCommand("SPExcluirFuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdFuncionario", Id);
                
                cmd.ExecuteNonQuery();
            }
        }

        public List<Funcionario> FindAll()
        {
            using (conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string query = "select * from VW_Funcionarios";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();

                List<Funcionario> lista = new List<Funcionario>();

                while (dr.Read())
                {
                    Funcionario func = new Funcionario();
                    func.Setor = new Setor();

                    func.IdFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                    func.Nome = Convert.ToString(dr["NomeFuncionario"]);
                    func.DataAdmissao = Convert.ToDateTime(dr["Admissao"]);
                    func.Setor.IdSetor = Convert.ToInt32(dr["IdSetor"]);
                    func.Setor.Nome = Convert.ToString(dr["NomeSetor"]);
                    func.Setor.Descricao = Convert.ToString(dr["Descricao"]);
                    lista.Add(func);

                }
                return lista;
            }
        }

        public Funcionario FindByID(int id)
        {
            using (conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string query = "select * from VW_Funcionarios where IdFuncionario = @IdFuncionario";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFuncionario", id);
                dr = cmd.ExecuteReader();

               if (dr.Read())
                {
                    Funcionario func = new Funcionario();
                    func.Setor = new Setor();

                    func.IdFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                    func.Nome = Convert.ToString(dr["NomeFuncionario"]);
                    func.DataAdmissao = Convert.ToDateTime(dr["Admissao"]);
                    func.Setor.IdSetor = Convert.ToInt32(dr["IdSetor"]);
                    func.Setor.Nome = Convert.ToString(dr["NomeSetor"]);
                    func.Setor.Descricao = Convert.ToString(dr["Descricao"]);
                    
                return func;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Funcionario> FindByName(string nome)
        {
            using (conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string query = "select * from VW_Funcionarios where NomeFuncionario LIKE @NomeFuncionario";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeFuncionario", nome);
                dr = cmd.ExecuteReader();

                List<Funcionario> lista = new List<Funcionario>();

                while (dr.Read())
                {
                    Funcionario func = new Funcionario();
                    func.Setor = new Setor();

                    func.IdFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                    func.Nome = Convert.ToString(dr["NomeFuncionario"]);
                    func.DataAdmissao = Convert.ToDateTime(dr["Admissao"]);
                    func.Setor.IdSetor = Convert.ToInt32(dr["IdSetor"]);
                    func.Setor.Nome = Convert.ToString(dr["NomeSetor"]);
                    func.Setor.Descricao = Convert.ToString(dr["Descricao"]);
                    lista.Add(func);

                }
                return lista;
            }
        }

        public void Insert(Funcionario funcionario)
        {
            using (conn = new SqlConnection(connectionString))
            {

                conn.Open();
                cmd = new SqlCommand("SPInserirFuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome",funcionario.Nome);
                cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                cmd.Parameters.AddWithValue("@IdSetor",funcionario.Setor.IdSetor);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Funcionario funcionario)
        {
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                cmd = new SqlCommand("SPAlterarFuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                cmd.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
                cmd.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
