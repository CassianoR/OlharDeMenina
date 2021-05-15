using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlharDeMenina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
