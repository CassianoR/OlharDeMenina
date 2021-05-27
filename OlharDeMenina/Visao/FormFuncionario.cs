using MySql.Data.MySqlClient;
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

        public int idFunc;

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

            PreencherListView();
            LimparCampos();
        }

        private void btn_ExcluirF_Click(object sender, EventArgs e)
        {
            idFunc = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);
            ControleFuncionario cf = new ControleFuncionario();
            cf.DeletarFuncionario(idFunc);
            LimparCampos();
            PreencherListView();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
            PreencherListView();
        }

        public void LimparCampos()
        {
            tbox_nome.Clear();
            tbox_cpf.Clear();
            tbox_endereco.Clear();
            tbox_telefone.Clear();
        }

        public void PreencherListView()
        {
            listView_funf.Items.Clear();
            MySqlDataReader dataReader;
            ControleFuncionario cf = new ControleFuncionario();
            dataReader = cf.RetornarFuncionarios(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetString(0));
                    lv.SubItems.Add(dataReader.GetString(2));
                    lv.SubItems.Add(dataReader.GetString(5));
                    lv.SubItems.Add(dataReader.GetString(4));
                    lv.SubItems.Add(dataReader.GetString(6));
                    listView_funf.Items.Add(lv);
                }
            }
        }
    }
}