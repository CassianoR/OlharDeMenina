using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNav.Hide();
        }

        // Mover janela
        private int mov;

        private int movX;
        private int movY;

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        

        private void btnVisao_Click(object sender, EventArgs e)
        {
            //Precisa fazer um forms separado pra visão geral!
            pnlNav.Show();
            pnlNav.Height = btnVisao.Height;
            pnlNav.Top = btnVisao.Top;
            pnlNav.Left = btnVisao.Left;
            btnVisao.BackColor = Color.FromArgb(249, 138, 237);
            lblTitulo.Text = "Visão Geral";
            panel3.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnEstoque.Height;
            pnlNav.Top = btnEstoque.Top;
            btnEstoque.BackColor = Color.FromArgb(249, 138, 237);
            // AbrirFormNoPanel<FormEstoque>();
            //lblTitulo.Text = "Estoque";
            //Corrigir o nome e descomentar quando for adicionado o formEstoque. 
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnHist.Height;
            pnlNav.Top = btnHist.Top;
            btnHist.BackColor = Color.FromArgb(249, 138, 237);
            // AbrirFormNoPanel<FormHist>();
            //lblTitulo.Text = "Histórico";
            //Corrigir o nome e descomentar quando for adicionado o formHist. 
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnVendas.Height;
            pnlNav.Top = btnVendas.Top;
            btnVendas.BackColor = Color.FromArgb(249, 138, 237);
            // AbrirFormNoPanel<FormVendas>();
            //lblTitulo.Text = "Vendas";
            //Corrigir o nome e descomentar quando for adicionado o formVendas. 
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnFunc.Height;
            pnlNav.Top = btnFunc.Top;
            btnFunc.BackColor = Color.FromArgb(249, 138, 237);
            AbrirFormNoPanel<FormFuncionario>();
            lblTitulo.Text = "Funcionários";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnClientes.Height;
            pnlNav.Top = btnClientes.Top;
            btnClientes.BackColor = Color.FromArgb(249, 138, 237);
            AbrirFormNoPanel<FormCliente>();
            lblTitulo.Text = "Clientes";
        }

        private void btnVisao_Leave(object sender, EventArgs e)
        {
            btnVisao.BackColor = Color.FromArgb(250, 88, 130);
        }

        private void btnEstoque_Leave(object sender, EventArgs e)
        {
            btnEstoque.BackColor = Color.FromArgb(250, 88, 130);
        }

        private void btnVendas_Leave(object sender, EventArgs e)
        {
            btnVendas.BackColor = Color.FromArgb(250, 88, 130);
        }

        private void btnHist_Leave(object sender, EventArgs e)
        {
            btnHist.BackColor = Color.FromArgb(250, 88, 130);
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(250, 88, 130);
        }

        private void btnFunc_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(250, 88, 130);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCon_Click_1(object sender, EventArgs e)
        {
            Conexao objCon = new Conexao();
            objCon.Open();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            panel3.Show();
            Form formulario;
            formulario = panel3.Controls.OfType<Forms>().FirstOrDefault();
            
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panel3.Controls.Add(formulario);
                panel3.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {   
                panel3.Controls.Remove(formulario);
                formulario.BringToFront();
                
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                formulario.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}