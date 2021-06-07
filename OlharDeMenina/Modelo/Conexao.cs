using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OlharDeMenina
{
    internal class Conexao
    {
        private MySqlConnection conn;
        private MySqlConnection con = new MySqlConnection("server=localhost; port=3306; User Id=root;database=OlharMeninaBD; password=muniz321; convert zero datetime=True");

        public MySqlConnection Conectar()
        {
            con.Open();
            return con;
        }

        public void Desconectar()
        {
            //Verifica se o estado da conexão é aberto, então fecho.
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        ///
        public bool Open()
        {
            try
            {
                conn = new MySqlConnection("server=localhost; port=3306; User Id=root;database=OlharMeninaBD; password=senha; convert zero datetime=True");
                conn.Open();
                //MessageBox.Show("Conectado com sucesso!");
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro de conexão: " + er.Message);
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}