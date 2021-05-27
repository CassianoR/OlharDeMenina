using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;



namespace OlharDeMenina
{
    public partial class Login : Form
    {
        string username, password;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mover janela
        int mov;
        int movX;
        int movY;
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
        //

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

        private void btn_login_entrar_Click(object sender, EventArgs e)
        {
            Conexao objCon = new Conexao();
            try
            {
                objCon.Open();
                
            
                if (txtB_nome.Text != "" && txtB_senha2.Text != "")
                {
                    objCon.Open();
                    string query = "select Nome,Senha from funcionarios WHERE Nome ='" + txtB_nome.Text + "' AND Senha ='" + txtB_senha2.Text + "'";
                    MySqlDataReader row;
                    row = objCon.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["Nome"].ToString();
                            password = row["Senha"].ToString();
                            //MessageBox.Show("Usuário: " + username + " conectado com sucesso");
                            this.Hide();
                            Form1 f1 = new Form1();
                            f1.ShowDialog();
                        }
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
            }
            catch
            {
                MessageBox.Show("Erro de conexão");
            }
        }
    }
}
