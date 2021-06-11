using MySql.Data.MySqlClient;
using OlharDeMenina.Controle;
using OlharDeMenina.Modelo;
using System;
using System.Windows.Forms;

namespace OlharDeMenina.Visao
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private int idProd;
        private string nomeClien;
        private int idClien;
        private string valor;

        private void btn_Adicionar_Click(object sender, System.EventArgs e)
        {
            Conexao objCon = new Conexao();
            nomeClien = cbox_cliente.GetItemText(cbox_cliente.SelectedItem);
            DateTime now = DateTime.Now;
            MySqlCommand cmd = new MySqlCommand("select Codigo from clientes where Nome = @nome", objCon.Conectar());
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new MySqlParameter("nome", nomeClien));
            MySqlDataReader dataReader = cmd.ExecuteReader();
            try
            {
                dataReader.Read();
                idClien = dataReader.GetInt32(0);
                //MessageBox.Show("IDProd: " + idProd + ", Data: " + now + ", IDClien: " + idClien + ", IDFunc" + idFunc);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

            ControleVenda cv = new ControleVenda();
            Vendas vendas = new Vendas(int.Parse(idFunc), idClien, valor, cbox_formasdepag.Text, "2021-06-03 04:10:02");
            cv.AdicionarVendas(vendas);
        }

        public string idFunc { get; set; }

        private void PreencherCheckbox()
        {
            listView1.Items.Clear();
            MySqlDataReader dataReader;
            ControleProduto cp = new ControleProduto();
            dataReader = cp.RetornarProdutos(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                do
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetInt32(0).ToString());
                    lv.SubItems.Add(dataReader.GetString(1));
                    lv.SubItems.Add(dataReader.GetString(6));
                    listView1.Items.Add(lv);
                }
                while (dataReader.Read());
            }
        }

        private void PreencherCombobox()
        {
            cbox_cliente.Items.Clear();
            MySqlDataReader dataReader;
            ControleCliente cc = new ControleCliente();
            dataReader = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                do
                {
                    cbox_cliente.Items.Add(dataReader.GetString(1));
                }
                while (dataReader.Read());
            }
        }

        private void FormVendas_Load(object sender, System.EventArgs e)
        {
            //listView1.CheckBoxes = true;
            PreencherCheckbox();
            PreencherCombobox();
            //MessageBox.Show("ID: " + idFunc);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            idProd = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Conexao objCon = new Conexao();
            MySqlCommand cmd = new MySqlCommand("select Valor from produto where Codigo = @codigo", objCon.Conectar());
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new MySqlParameter("codigo", idProd));
            MySqlDataReader dataReader = cmd.ExecuteReader();
            try
            {
                dataReader.Read();
                valor = dataReader.GetString(0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}