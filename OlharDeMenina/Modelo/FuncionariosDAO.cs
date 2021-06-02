using MySql.Data.MySqlClient;

namespace OlharDeMenina.Modelo
{
    internal class FuncionariosDAO
    {
        public string Mensagem { get; private set; }
        private MySqlCommand cmd = new MySqlCommand();
        private Conexao con = new Conexao();

        private MySqlDataReader dr;

        public string Adicionar(Funcionarios funcionarios)
        {
            cmd.CommandText = "insert into funcionarios (Cargo, Nome, CPF, Senha, Telefone, Endereço) values (@cargo, @nome, @cpf, @senha, @telefone, @endereco)";
            cmd.Parameters.AddWithValue("cargo", funcionarios.Cargo);
            cmd.Parameters.AddWithValue("nome", funcionarios.Nome);
            cmd.Parameters.AddWithValue("cpf", funcionarios.CPF);
            cmd.Parameters.AddWithValue("senha", funcionarios.Senha);
            cmd.Parameters.AddWithValue("telefone", funcionarios.Telefone);
            cmd.Parameters.AddWithValue("endereco", funcionarios.Endereço);
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
            string query = "SELECT * FROM funcionarios";
            MySqlCommand cmd = new MySqlCommand(query, con.Conectar());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            try
            {
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    Mensagem = "Dados atualizados com sucesso!";
                    //System.Windows.Forms.MessageBox.Show(Mensagem);
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
            cmd.CommandText = "delete from funcionarios where ID = @id";
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