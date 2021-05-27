using System;
using System.Windows.Forms;
using OlharDeMenina.Controle;
using OlharDeMenina.Modelo;
using MySql.Data.MySqlClient;

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


            PreencherListView();
            LimparCampos();
        }

        private void btn_ExcluirF_Click(object sender, EventArgs e)
        {


            PreencherListView();
            LimparCampos();
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