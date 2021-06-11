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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            idFunc = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);
            ControleFuncionario cf = new ControleFuncionario();
            cf.DeletarFuncionario(idFunc);
            LimparCampos();
            PreencherListView();
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
                do
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetInt32(0).ToString());
                    lv.SubItems.Add(dataReader.GetString(1));
                    lv.SubItems.Add(dataReader.GetString(2));
                    lv.SubItems.Add(dataReader.GetString(3));
                    lv.SubItems.Add(dataReader.GetString(5));
                    lv.SubItems.Add(dataReader.GetString(6));
                    listView_funf.Items.Add(lv);
                }
                while (dataReader.Read());
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            ControleFuncionario cf = new ControleFuncionario();
            Funcionarios funcionario = new Funcionarios("Funcionário", tbox_nome.Text, tbox_cpf.Text, "1234", tbox_telefone.Text, tbox_endereco.Text);
            cf.AdicionarFuncionarios(funcionario);

            PreencherListView();
            LimparCampos();
        }

        private void listView_funf_Click(object sender, EventArgs e)
        {
            idFunc = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);
            ControleFuncionario cf = new ControleFuncionario();
            MySqlDataReader dr = cf.RetornarFuncionarios(idFunc);

            if (dr != null)
            {
                dr.Read();

                tbox_nome.Text = dr.GetString(2);
                tbox_cpf.Text = dr.GetString(3);
                tbox_telefone.Text = dr.GetString(5);
                tbox_endereco.Text = dr.GetString(6);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ControleFuncionario cf = new ControleFuncionario();
            Funcionarios funcionario = new Funcionarios("Funcionário", tbox_nome.Text, tbox_cpf.Text, "1234", tbox_telefone.Text, tbox_endereco.Text);

            idFunc = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);

            string mensagem = cf.EditarFuncionario(funcionario, idFunc);

            MessageBox.Show(mensagem);

            PreencherListView();
            LimparCampos();
        }
    }
}