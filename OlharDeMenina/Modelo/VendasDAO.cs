using MySql.Data.MySqlClient;

namespace OlharDeMenina.Modelo
{
    internal class VendasDAO
    {
        public string Mensagem { get; private set; }
        private MySqlCommand cmd = new MySqlCommand();
        private Conexao con = new Conexao();

        public string Adicionar(Vendas vendas)
        {
            con.Close();
            cmd.CommandText = "INSERT INTO Vendas (FK_IDFuncionario, FK_CodigoCliente, Valor, MetodoPagamento, DataHora) values (@fk_idfuncionario, @fk_codigocliente, @valor, @metodopagamento, @datahora)";
            cmd.Parameters.AddWithValue("fk_idfuncionario", vendas.FK_CodigoFuncionario);
            cmd.Parameters.AddWithValue("fk_codigocliente", vendas.FK_CodigoCliente);
            cmd.Parameters.AddWithValue("valor", vendas.Valor);
            cmd.Parameters.AddWithValue("metodopagamento", vendas.MetodoPagamento);
            cmd.Parameters.AddWithValue("datahora", vendas.DataHora);
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

        public MySqlDataReader RetornaVendas()
        {
            con.Close();
            string query = "SELECT * FROM vendas";
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

        public MySqlDataReader RetornaVendas(int idProd)
        {
            con.Close();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Produto WHERE Codigo = @id", con.Conectar());
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new MySqlParameter("id", idProd));
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

        public string DeletarVendas(int idProd)
        {
            con.Close();
            cmd.CommandText = "delete from produto where Codigo = @id";
            cmd.Parameters.AddWithValue("id", idProd);
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

        public string EditarProdutos(Produtos produtos, int idProd)
        {
            con.Close();
            cmd.CommandText = "UPDATE produto SET NomeProduto = @nomeproduto, Marca = @marca, Categoria = @categoria, Descricao = @descricao, Valor = @valor, Quantidade = @quantidade WHERE Codigo = @id";
            cmd.Parameters.AddWithValue("nomeproduto", produtos.NomeProduto);
            cmd.Parameters.AddWithValue("marca", produtos.Marca);
            cmd.Parameters.AddWithValue("categoria", produtos.Categoria);
            cmd.Parameters.AddWithValue("descricao", produtos.Descricao);
            cmd.Parameters.AddWithValue("valor", produtos.Valor);
            cmd.Parameters.AddWithValue("quantidade", produtos.Quantidade);
            cmd.Parameters.AddWithValue("id", idProd);

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