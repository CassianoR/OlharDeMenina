using OlharDeMenina.Controle;
using OlharDeMenina.Modelo;
using System;
using System.Windows.Forms;

namespace OlharDeMenina
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btn_AdicionarF_Click(object sender, EventArgs e)
        {
            ControleFuncionario cf = new ControleFuncionario();
            Funcionarios funcionario = new Funcionarios(tbox_nome.Text, tbox_cpf.Text, "1234", tbox_telefone.Text, tbox_endereco.Text);
            cf.AdicionarFuncionarios(funcionario);
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

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
        }
    }
}