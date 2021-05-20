using MySql.Data.MySqlClient;
using System;

namespace OlharDeMenina.Modelo
{
    internal class FuncionariosDAO
    {
        public string Mensagem { get; private set; }
        private MySqlCommand cmd = new MySqlCommand();
        private Conexao con = new Conexao();

        private MySqlDataReader dr;

        public string Adicionar(Funcionarios funcAdd)
        {
            cmd.CommandText = "insert into Funcionarios (Nome, CPF, Senha, Telefone, Endereço) values (@nome, @cpf, @senha, @telefone, @endereco)";

            cmd.Parameters.AddWithValue("nome", funcAdd.Nome);
            cmd.Parameters.AddWithValue("cpf", funcAdd.CPF);
            cmd.Parameters.AddWithValue("senha", funcAdd.Senha);
            cmd.Parameters.AddWithValue("telefone", funcAdd.Telefone);
            cmd.Parameters.AddWithValue("endereco", funcAdd.Endereço);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Cadastrado com sucesso!!!";
            }
            catch (MySqlException ex)
            {
                Mensagem = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(Mensagem);
            return Mensagem;
        }

        public MySqlCommand RetornaFuncionarios()
        {
            cmd.CommandText = "select * from Funcionarios";

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                //if (dr.HasRows)
                //{
                //bool v = dr;
                //  return v;
                // }
            }
            catch (MySqlException)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine("Algo errado não está certo!");
            }
            con.Desconectar();
            return null;
        }

        public string Deletar(int indice)
        {
            //Comandos para inserir novo usuário no banco.
            //Comando SQL
            cmd.CommandText = "delete from Funcionarios where ID = @id";
            //parametros
            cmd.Parameters.AddWithValue("id", indice);
            //conectar com banco
            try
            {
                //Receber o endereço de onde vou me conectar.
                cmd.Connection = con.Conectar();
                //Executar comando.
                cmd.ExecuteNonQuery();
                //Exibe mensagem;
                Mensagem = "Deletado com sucesso!!!";
            }
            catch (MySqlException ex)
            {
                //Captura a mensagem de erro gerada.
                Mensagem = ex.Message;
            }
            return Mensagem;
        }
    }
}