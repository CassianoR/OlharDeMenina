using MySql.Data.MySqlClient;

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

        public MySqlDataReader RetornaFuncionarios()
        {
            string query = "SELECT * FROM Funcionarios";
            MySqlCommand cmd = new MySqlCommand(query, con.Conectar());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            try
            {
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    Mensagem = "Dados atualizados com sucesso!";
                    System.Windows.Forms.MessageBox.Show(Mensagem);
                }
                else
                {
                    Mensagem = "Não há dados na tabela.";
                    System.Windows.Forms.MessageBox.Show(Mensagem);
                }
                return dataReader;
            }
            catch (MySqlException ex)
            {
                Mensagem = ex.Message;
                System.Windows.Forms.MessageBox.Show(Mensagem);
                return dataReader;
            }
        }

        public string DeletarFuncionarios(int idFunc)
        {
            cmd.CommandText = "delete from Funcionarios where ID = @id";
            cmd.Parameters.AddWithValue("id", idFunc);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Deletado com sucesso!!!";
            }
            catch (MySqlException ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }
    }
}