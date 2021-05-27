using System;
using System.Windows.Forms;

namespace OlharDeMenina
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btn_AdicionarF_Click(object sender, EventArgs e)
        {
        }

        private void btn_ExcluirF_Click(object sender, EventArgs e)
        {
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tbox_nome.Text = String.Empty;
            tbox_cpf.Text = String.Empty;
            tbox_endereco.Text = String.Empty;
            tbox_telefone.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MySqlConnection objCon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=OlharMeninaBD; password=usbw");
                Conexao objCon = new Conexao();
                objCon.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar :(");
            }
        }
    }
}