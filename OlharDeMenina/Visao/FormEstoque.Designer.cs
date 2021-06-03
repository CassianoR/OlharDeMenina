﻿
namespace OlharDeMenina.Visao
{
    partial class FormEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_funf = new System.Windows.Forms.ListView();
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbox_marca = new System.Windows.Forms.TextBox();
            this.tbox_categoria = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.ch_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.White;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_quantidade,
            this.ch_nome,
            this.ch_marca,
            this.ch_categoria,
            this.ch_descricao,
            this.ch_valor});
            this.listView_funf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_funf.FullRowSelect = true;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(0, 188);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(748, 268);
            this.listView_funf.TabIndex = 21;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_id
            // 
            this.ch_id.Text = "ID";
            this.ch_id.Width = 38;
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 146;
            // 
            // ch_marca
            // 
            this.ch_marca.Text = "Marca";
            this.ch_marca.Width = 125;
            // 
            // ch_categoria
            // 
            this.ch_categoria.Text = "Categoria";
            this.ch_categoria.Width = 91;
            // 
            // ch_descricao
            // 
            this.ch_descricao.Text = "Descrição";
            this.ch_descricao.Width = 209;
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
            this.ch_valor.Width = 70;
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_cadastro.Controls.Add(this.textBox1);
            this.pnl_cadastro.Controls.Add(this.lbl_valor);
            this.pnl_cadastro.Controls.Add(this.nud_quantidade);
            this.pnl_cadastro.Controls.Add(this.label3);
            this.pnl_cadastro.Controls.Add(this.tbox_marca);
            this.pnl_cadastro.Controls.Add(this.tbox_categoria);
            this.pnl_cadastro.Controls.Add(this.lbl_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_endereco);
            this.pnl_cadastro.Controls.Add(this.tbox_endereco);
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.tbox_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_marca);
            this.pnl_cadastro.Location = new System.Drawing.Point(0, 12);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(521, 150);
            this.pnl_cadastro.TabIndex = 22;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(16, 88);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 26);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // tbox_marca
            // 
            this.tbox_marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_marca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_marca.Location = new System.Drawing.Point(206, 33);
            this.tbox_marca.MaxLength = 200;
            this.tbox_marca.Name = "tbox_marca";
            this.tbox_marca.Size = new System.Drawing.Size(186, 22);
            this.tbox_marca.TabIndex = 1;
            // 
            // tbox_categoria
            // 
            this.tbox_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_categoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_categoria.Location = new System.Drawing.Point(12, 87);
            this.tbox_categoria.MaxLength = 200;
            this.tbox_categoria.Name = "tbox_categoria";
            this.tbox_categoria.Size = new System.Drawing.Size(179, 22);
            this.tbox_categoria.TabIndex = 2;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_telefone.ForeColor = System.Drawing.Color.Gray;
            this.lbl_telefone.Location = new System.Drawing.Point(14, 63);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(84, 21);
            this.lbl_telefone.TabIndex = 17;
            this.lbl_telefone.Text = "Categoria";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_endereco.ForeColor = System.Drawing.Color.Gray;
            this.lbl_endereco.Location = new System.Drawing.Point(202, 62);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(83, 21);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Descrição";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(144, 88);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(59, 26);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_endereco.Location = new System.Drawing.Point(206, 87);
            this.tbox_endereco.Multiline = true;
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(186, 22);
            this.tbox_endereco.TabIndex = 3;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_Adicionar.Location = new System.Drawing.Point(16, 32);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(97, 50);
            this.btn_Adicionar.TabIndex = 6;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Salmon;
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(116, 31);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 50);
            this.btn_Excluir.TabIndex = 7;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_nome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nome.Location = new System.Drawing.Point(14, 10);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(57, 21);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            // 
            // tbox_nome
            // 
            this.tbox_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_nome.Location = new System.Drawing.Point(12, 34);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(179, 22);
            this.tbox_nome.TabIndex = 0;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_marca.ForeColor = System.Drawing.Color.Gray;
            this.lbl_marca.Location = new System.Drawing.Point(202, 9);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(58, 21);
            this.lbl_marca.TabIndex = 3;
            this.lbl_marca.Text = "Marca";
            // 
            // ch_quantidade
            // 
            this.ch_quantidade.Text = "Quantidade";
            this.ch_quantidade.Width = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(407, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quant.";
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.Location = new System.Drawing.Point(411, 35);
            this.nud_quantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(74, 20);
            this.nud_quantidade.TabIndex = 4;
            this.nud_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_valor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_valor.Location = new System.Drawing.Point(407, 61);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(50, 21);
            this.lbl_valor.TabIndex = 21;
            this.lbl_valor.Text = "Valor";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(411, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 22);
            this.textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Adicionar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Location = new System.Drawing.Point(527, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 150);
            this.panel1.TabIndex = 22;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_cadastro);
            this.Controls.Add(this.listView_funf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_funf;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_marca;
        private System.Windows.Forms.ColumnHeader ch_categoria;
        private System.Windows.Forms.ColumnHeader ch_descricao;
        private System.Windows.Forms.ColumnHeader ch_valor;
        private System.Windows.Forms.ColumnHeader ch_quantidade;
        private System.Windows.Forms.Panel pnl_cadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox tbox_marca;
        private System.Windows.Forms.TextBox tbox_categoria;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.NumericUpDown nud_quantidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Panel panel1;
    }
}