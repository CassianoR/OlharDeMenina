using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

    


namespace OlharDeMenina
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void visãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNav.Hide();
        }

        private void btnVisao_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnVisao.Height;
            pnlNav.Top = btnVisao.Top;
            pnlNav.Left = btnVisao.Left;
            btnVisao.BackColor = Color.FromArgb(249, 138, 237);
            var form_log = new Login();
            form_log.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnEstoque.Height;
            pnlNav.Top = btnEstoque.Top;
            btnEstoque.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnPedidos.Height;
            pnlNav.Top = btnPedidos.Top;
            btnPedidos.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnHist.Height;
            pnlNav.Top = btnHist.Top;
            btnHist.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnConfig.Height;
            pnlNav.Top = btnConfig.Top;
            btnConfig.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnVisao_Leave(object sender, EventArgs e)
        {
            btnVisao.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnEstoque_Leave(object sender, EventArgs e)
        {
            btnEstoque.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnPedidos_Leave(object sender, EventArgs e)
        {
            btnPedidos.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnHist_Leave(object sender, EventArgs e)
        {
            btnHist.BackColor = Color.FromArgb(249, 138, 237);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(249, 138, 237);
        }

        private async void FadeIn(Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible    
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible  
            Environment.Exit(-1);
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FadeOut(this, 20);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objCon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=OlharMeninaBD; password=usbw");
                objCon.Open();
                MessageBox.Show("Conectado com sucesso!");
                objCon.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar :(");
            }
        }
    }
}
