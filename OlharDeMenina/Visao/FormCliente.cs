﻿using System;
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
        public int idClien;
        private void btn_AdicionarC_Click(object sender, EventArgs e)
        {
            ControleCliente cc = new ControleCliente();
            Clientes clientes = new Clientes(tbox_nome.Text, tbox_telefone.Text, tbox_endereco.Text, tbox_datadenascimento.Text);
            cc.AdicionarClientes(clientes);

            PreencherListView();
            LimparCampos();
        }

        private void btn_ExcluirC_Click(object sender, EventArgs e)
        {
            idClien = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);
            ControleCliente cc = new ControleCliente();
            cc.DeletarClientes(idClien);

            PreencherListView();
            LimparCampos();
        }


        public void LimparCampos()
        {
            tbox_nome.Clear();
            tbox_datadenascimento.Clear();
            tbox_endereco.Clear();
            tbox_telefone.Clear();
        }

        public void PreencherListView()
        {
            listView_funf.Items.Clear();
            MySqlDataReader dataReader;
            ControleCliente cf = new ControleCliente();
            dataReader = cf.RetornarClientes(); //Chama o método responsável pela realização da consulta.

            if (dataReader != null) //Verifico
            {
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader.GetInt32(0).ToString());
                    lv.SubItems.Add(dataReader.GetString(1));
                    lv.SubItems.Add(dataReader.GetString(2));
                    lv.SubItems.Add(dataReader.GetString(3));
                    lv.SubItems.Add(dataReader.GetDateTime(4).ToString());
                    listView_funf.Items.Add(lv);
                }
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
            Clientes clientes = new Clientes(tbox_nome.Text, tbox_telefone.Text, tbox_endereco.Text, tbox_datadenascimento.Text);

            idClien = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);

            string mensagem = cc.EditarClientes(clientes, idClien);

            MessageBox.Show(mensagem);

            PreencherListView();
            LimparCampos();
        }

        private void listView_funf_Click(object sender, EventArgs e)
        {
            idClien = int.Parse(listView_funf.SelectedItems[0].SubItems[0].Text);
            ControleCliente cf = new ControleCliente();
            MySqlDataReader dr = cf.RetornarClientes(idClien);

            if (dr != null)
            {
                while (dr.Read())
                {
                    tbox_nome.Text = dr.GetString(1);
                    tbox_telefone.Text = dr.GetString(2);
                    tbox_endereco.Text = dr.GetString(3);
                    tbox_datadenascimento.Text = dr.GetDateTime(4).ToString();
                }
            }
        }
    }
}