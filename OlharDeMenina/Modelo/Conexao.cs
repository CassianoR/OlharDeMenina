using MySql.Data.MySqlClient;
using System;
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
                con.Open();
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
    }
}