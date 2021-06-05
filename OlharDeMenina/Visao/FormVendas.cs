using MySql.Data.MySqlClient;
using OlharDeMenina.Controle;
using System.Windows.Forms;

namespace OlharDeMenina.Visao
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, System.EventArgs e)
        {

        }

        private void PreencherCheckbox()
        {
            listView1.Items.Clear();
            MySqlDataReader dataReader;
            ControleProduto cp = new ControleProduto();
            dataReader = cp.RetornarProdutos(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetString(1));
                    listView1.Items.Add(lv);
                }
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
                while (dataReader.Read())
                {
                    cbox_cliente.Items.Add(dataReader.GetString(1));
                }
            }
        }
        private void FormVendas_Load(object sender, System.EventArgs e)
        {
            listView1.CheckBoxes = true;
            PreencherCheckbox();
            PreencherCombobox();
        }
    }
}