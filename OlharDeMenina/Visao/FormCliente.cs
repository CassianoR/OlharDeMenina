using MySql.Data.MySqlClient;
using OlharDeMenina.Controle;
using OlharDeMenina.Modelo;
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

        //solução para a busca da internet que não foi finalizada. depois vou tentar elaborar nisso, mas fica aí pra história. ass: Vitor
        private string[] nomeLista = { };

        private string[] CPFLista = { };
        private string[] telefoneLista = { };
        private int index = 0;

        public int idClien;

        private void btn_AdicionarC_Click(object sender, EventArgs e)
        {
            ControleCliente cc = new ControleCliente();
            Clientes clientes = new Clientes(tbox_nome.Text, tbox_cpf.Text, tbox_telefone.Text, tbox_endereco.Text, tbox_datadenascimento.Text);
            cc.AdicionarClientes(clientes);
            //nomeLista[index] = tbox_nome.Text;
            //CPFLista[index] = tbox_cpf.Text;
            telefoneLista[index] = tbox_telefone.Text;
            PreencherListView();
            LimparCampos();
            //index += 1 ;
        }
        private void btn_ExcluirC_Click(object sender, EventArgs e)
        {
            idClien = int.Parse(listView_clie.SelectedItems[0].SubItems[0].Text);
            ControleCliente cc = new ControleCliente();
            cc.DeletarClientes(idClien);

            PreencherListView();
            LimparCampos();
        }
        public void LimparCampos()
        {
            tbox_nome.Clear();
            tbox_cpf.Clear();
            tbox_datadenascimento.Clear();
            tbox_endereco.Clear();
            tbox_telefone.Clear();
        }

        public void PreencherListView()
        {
            listView_clie.Items.Clear();
            MySqlDataReader dataReader;
            ControleCliente cc = new ControleCliente();
            dataReader = cc.RetornarClientes();

            if (dataReader != null) //Verifico
            {
                do
                {
                    try
                    {
                        ListViewItem lv = new ListViewItem(dataReader.GetInt32(0).ToString());
                        lv.SubItems.Add(dataReader.GetString(1));
                        lv.SubItems.Add(dataReader.GetString(2));
                        lv.SubItems.Add(dataReader.GetString(3));
                        lv.SubItems.Add(dataReader.GetString(4));
                        lv.SubItems.Add(dataReader.GetString(5));
                        listView_clie.Items.Add(lv);
                    }
                    catch { }
                } while (dataReader.Read());
            }
        }

        private void btn_limparC_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ControleCliente cc = new ControleCliente();
            Clientes clientes = new Clientes(tbox_nome.Text, tbox_cpf.Text, tbox_telefone.Text, tbox_endereco.Text, tbox_datadenascimento.Text);

            idClien = int.Parse(listView_clie.SelectedItems[0].SubItems[0].Text);

            string mensagem = cc.EditarClientes(clientes, idClien);

            MessageBox.Show(mensagem);

            PreencherListView();
            LimparCampos();
        }

        private void listView_funf_Click(object sender, EventArgs e)
        {
            idClien = int.Parse(listView_clie.SelectedItems[0].SubItems[0].Text);
            ControleCliente cf = new ControleCliente();
            MySqlDataReader dr = cf.RetornarClientes(idClien);

            if (dr != null)
            {
                dr.Read();

                tbox_nome.Text = dr.GetString(1);
                tbox_cpf.Text = dr.GetString(2);
                tbox_telefone.Text = dr.GetString(3);
                tbox_endereco.Text = dr.GetString(4);
                tbox_datadenascimento.Text = dr.GetString(5);
            }
        }

        private void botaoBuscar_Click_1(object sender, EventArgs e)
        {
            // isso aqui é vindo do banco de dados para fazer a pesquisa. é uma solução, mas meio gambiarra kk ass: Vitor

            try
            {
                ControleCliente cf = new ControleCliente();
                MySqlDataReader dr = cf.RetornarClientes(Int32.Parse(caixaBuscar.Text));

                if (dr != null)
                {
                    dr.Read();

                    tbox_nome.Text = dr.GetString(1);
                    tbox_cpf.Text = dr.GetString(2);
                    tbox_telefone.Text = dr.GetString(3);
                    tbox_endereco.Text = dr.GetString(4);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}