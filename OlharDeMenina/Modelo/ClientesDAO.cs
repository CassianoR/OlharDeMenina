using MySql.Data.MySqlClient;

namespace OlharDeMenina.Modelo
{
    internal class ClientesDAO
    {
        public string Mensagem { get; private set; }
        private MySqlCommand cmd = new MySqlCommand();
        private Conexao con = new Conexao();

        private MySqlDataReader dr;

        public string Adicionar(Clientes clientes)
        {
            con.Close();
            cmd.CommandText = "insert into clientes (Nome, CPF, Telefone, Endereco, DataNasc) values (@nome, @cpf, @telefone, @endereco, @datanasc)";
            cmd.Parameters.AddWithValue("nome", clientes.Nome);
            cmd.Parameters.AddWithValue("cpf", clientes.CPF);
            cmd.Parameters.AddWithValue("telefone", clientes.Telefone);
            cmd.Parameters.AddWithValue("endereco", clientes.Endereço);
            cmd.Parameters.AddWithValue("datanasc", clientes.DataNasc);
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

        public MySqlDataReader RetornaClientes()
        {
            con.Close();
            string query = "SELECT * FROM clientes";
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

        public MySqlDataReader RetornaClientes(int idClien)
        {
            con.Close();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM clientes WHERE Codigo = @id", con.Conectar());
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new MySqlParameter("id", idClien));
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
                System.Windows.Forms.MessageBox.Show(Mensagem + ex);
                return dataReader;
            }
        }

        public string DeletarClientes(int idClien)
        {
            con.Close();
            cmd.CommandText = "delete from clientes where Codigo = @id";
            cmd.Parameters.AddWithValue("id", idClien);
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

        public string EditarClientes(Clientes clientes, int idClien)
        {
            con.Close();
            cmd.CommandText = "UPDATE clientes SET Nome = @nome, CPF = @cpf, Telefone = @telefone, Endereco = @endereco, DataNasc = @datanasc WHERE Codigo = @id";
            cmd.Parameters.AddWithValue("nome", clientes.Nome);
            cmd.Parameters.AddWithValue("cpf", clientes.CPF);
            cmd.Parameters.AddWithValue("telefone", clientes.Telefone);
            cmd.Parameters.AddWithValue("endereco", clientes.Endereço);
            cmd.Parameters.AddWithValue("datanasc", clientes.DataNasc);
            cmd.Parameters.AddWithValue("id", idClien);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Atualizado com Sucesso";
            }
            catch (MySqlException ex)
            {
                Mensagem = ex.Message;
            }

            return Mensagem;
        }
    }
}