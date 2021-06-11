using MySql.Data.MySqlClient;
using OlharDeMenina.Controle;
using System;
using System.Windows.Forms;

namespace OlharDeMenina.Visao
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        public string idUser { get; set; }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            LimparCampos();
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            try
            {
                ControleFuncionario cf = new ControleFuncionario();
                MySqlDataReader dr = cf.RetornarFuncionarios(Int32.Parse(idUser));

                if (dr != null)
                {
                    dr.Read();

                    lbl_nome.Text = dr.GetString(2);
                    lbl_senha.Text = dr.GetInt32(4).ToString();
                    lbl_cargo.Text = dr.GetString(1);
                    lbl_cpf.Text = dr.GetString(3);
                    lbl_telefone.Text = dr.GetString(5);
                    lbl_endereco.Text = dr.GetString(6);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void LimparCampos()
        {
            lbl_nome.Text = string.Empty;
            lbl_senha.Text = string.Empty;
            lbl_cargo.Text = string.Empty;
            lbl_cpf.Text = string.Empty;
            lbl_telefone.Text = string.Empty;
            lbl_endereco.Text = string.Empty;
        }
    }
}