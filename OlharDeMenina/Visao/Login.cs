using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace OlharDeMenina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mover janela
        private int mov;

        private int movX;
        private int movY;

        private void pnl_superior_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnl_superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnl_superior_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtB_senha1.Text = txtB_senha2.Text;
        }

        private void pic_olho_MouseDown(object sender, MouseEventArgs e)
        {
            txtB_senha2.Hide();
        }

        private void pic_olho_MouseUp(object sender, MouseEventArgs e)
        {
            txtB_senha2.Show();
        }

        private void txtB_nome_Click(object sender, EventArgs e)
        {
            if (txtB_nome.Text == "Nome")
            {
                txtB_nome.Clear();
            }
        }

        private void txtB_senha2_Click(object sender, EventArgs e)
        {
            if (txtB_senha2.Text == "Senha")
            {
                txtB_senha2.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login_entrar;
        }

        private void btn_login_entrar_Click(object sender, EventArgs e)
        {
            //Conexao objCon = new Conexao();
            MySqlConnection objCon = new MySqlConnection("server=localhost; port=3307; User Id=root;database=OlharMeninaBD; password=senha; convert zero datetime=True");
            Form1 f = new Form1();
            try
            {
                objCon.Open();

                if (txtB_nome.Text != "" && txtB_senha2.Text != "")
                {
                   // string query = "select ID, Nome, Senha from funcionarios WHERE Nome ='" + txtB_nome.Text + "' AND Senha ='" + txtB_senha2.Text + "'";
                    MySqlCommand objCmd = new MySqlCommand("select ID, Nome, Senha from funcionarios WHERE Nome = @nome AND Senha = @senha", objCon);
                    objCmd.Parameters.Clear();
                    objCmd.Parameters.AddWithValue("nome", txtB_nome.Text);
                    objCmd.Parameters.AddWithValue("senha", txtB_senha2.Text);
                    MySqlDataReader dr;
                    dr = objCmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        f.idFunc = dr.GetInt32(0).ToString();
                        f.username = dr.GetString("Nome");
                        f.password = dr.GetInt32("Senha").ToString();

                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Campos de texto não podem estar vazios.");
                }

                objCon.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro de conexão: " + ex);
            }
        }
    }
}