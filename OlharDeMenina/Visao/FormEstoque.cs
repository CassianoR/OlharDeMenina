using MySql.Data.MySqlClient;
using OlharDeMenina.Controle;
using OlharDeMenina.Modelo;
using System;
using System.Windows.Forms;

namespace OlharDeMenina.Visao
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private int idProd;

        public void PreencherListView()
        {
            listView_esto.Items.Clear();
            MySqlDataReader dataReader;
            ControleProduto cp = new ControleProduto();
            dataReader = cp.RetornarProdutos(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                do
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetInt32(0).ToString());
                    lv.SubItems.Add(dataReader.GetString(1));
                    lv.SubItems.Add(dataReader.GetString(2));
                    lv.SubItems.Add(dataReader.GetString(3));
                    lv.SubItems.Add(dataReader.GetInt32(4).ToString());
                    lv.SubItems.Add(dataReader.GetString(5));
                    lv.SubItems.Add(dataReader.GetDouble(6).ToString());
                    listView_esto.Items.Add(lv);
                } while (dataReader.Read());

            }
        }

        private void listView_funf_Click(object sender, EventArgs e)
        {
            idProd = int.Parse(listView_esto.SelectedItems[0].SubItems[0].Text);
            ControleProduto cp = new ControleProduto();
            MySqlDataReader dr = cp.RetornarProdutos(idProd);

            if (dr != null)
            {
                dr.Read();
                tbox_nome.Text = dr.GetString(1);
                tbox_marca.Text = dr.GetString(2);
                tbox_categoria.Text = dr.GetString(3);
                tbox_descricao.Text = dr.GetString(5);
                tbox_quantidade.Value = dr.GetInt32(4);
                tbox_valor.Text = dr.GetString(6);
            }
        }

        public void LimparCampos()
        {
            tbox_nome.Clear();
            tbox_marca.Clear();
            tbox_categoria.Clear();
            tbox_descricao.Clear();
            tbox_valor.Clear();
            tbox_quantidade.Value = 1;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            ControleProduto cp = new ControleProduto();
            Produtos produtos = new Produtos(tbox_nome.Text, tbox_marca.Text, tbox_categoria.Text, tbox_descricao.Text, tbox_valor.Text, Convert.ToInt32(tbox_quantidade.Value));
            cp.AdicionarProdutos(produtos);

            PreencherListView();
            LimparCampos();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            idProd = int.Parse(listView_esto.SelectedItems[0].SubItems[0].Text);
            ControleProduto cp = new ControleProduto();
            cp.DeletarProdutos(idProd);
            LimparCampos();
            PreencherListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ControleProduto cp = new ControleProduto();
            Produtos produtos = new Produtos(tbox_nome.Text, tbox_marca.Text, tbox_categoria.Text, tbox_descricao.Text, tbox_valor.Text, Convert.ToInt32(tbox_quantidade.Value));

            idProd = int.Parse(listView_esto.SelectedItems[0].SubItems[0].Text);

            string mensagem = cp.EditarProdutos(produtos, idProd);

            MessageBox.Show(mensagem);

            PreencherListView();
            LimparCampos();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }
    }
}