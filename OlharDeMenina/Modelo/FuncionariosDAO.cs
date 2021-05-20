using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlharDeMenina.Modelo
{
    class FuncionariosDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public string Adicionar(Funcionarios funcAdd)
        {
            cmd.CommandText = "insert into Funcionarios (Id, Cargo, Nome, CPF, Senha, Telefone, Endereço) values (@id, @cargo, @nome, @cpf, @senha, @telefone, @endereco)";

            cmd.Parameters.AddWithValue("id", funcAdd.ID);
            cmd.Parameters.AddWithValue("cargo", funcAdd.Cargo);
            cmd.Parameters.AddWithValue("nome", funcAdd.Nome);
            cmd.Parameters.AddWithValue("cpf", funcAdd.CPF);
            cmd.Parameters.AddWithValue("senha", funcAdd.Senha);
            cmd.Parameters.AddWithValue("telefone", funcAdd.Telefone);
            cmd.Parameters.AddWithValue("endereco", funcAdd.Endereço);
            try
            {
                Conexao objCon = new Conexao();
                objCon.Open();
                cmd.ExecuteNonQuery();
                Mensagem = "Cadastrado com sucesso!!!";
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }

        public SqlDataReader DadosFuncionarios()
        {
            cmd.CommandText = "select * from Funcionarios";


            try
            {
                //cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Ocorreu algum erro, então fecha o programa e abre de novo. :)");
            }
            //con.Desconectar();
            return null;
        }

        public SqlDataReader DadosFuncionario(int IdAlun)
        {
            cmd.CommandText = "select * from Funcionarios where ID = @idfunf";


            try
            {
                //cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Ocorreu algum erro, então fecha o programa e abre de novo. :)");
            }
            //con.Desconectar();
            return null;
        }
    }
}
