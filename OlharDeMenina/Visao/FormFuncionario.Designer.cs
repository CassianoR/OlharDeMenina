
namespace OlharDeMenina
{
    partial class FormFuncionario
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
            this.ch_cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tbox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.White;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_cargo,
            this.ch_nome,
            this.ch_cpf,
            this.ch_telefone,
            this.ch_endereco});
            this.listView_funf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_funf.FullRowSelect = true;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(0, 188);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(748, 268);
            this.listView_funf.TabIndex = 20;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            this.listView_funf.Click += new System.EventHandler(this.listView_funf_Click);
            // 
            // ch_id
            // 
            this.ch_id.Text = "ID";
            // 
            // ch_cargo
            // 
            this.ch_cargo.Text = "Cargo";
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 164;
            // 
            // ch_cpf
            // 
            this.ch_cpf.Text = "CPF";
            this.ch_cpf.Width = 153;
            // 
            // ch_telefone
            // 
            this.ch_telefone.Text = "Telefone";
            this.ch_telefone.Width = 152;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "Endereço";
            this.ch_endereco.Width = 224;
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_cadastro.Controls.Add(this.btnEditar);
            this.pnl_cadastro.Controls.Add(this.tbox_cpf);
            this.pnl_cadastro.Controls.Add(this.tbox_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_limpar);
            this.pnl_cadastro.Controls.Add(this.tbox_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_Adicionar);
            this.pnl_cadastro.Controls.Add(this.btn_Excluir);
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.tbox_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_cpf);
            this.pnl_cadastro.Location = new System.Drawing.Point(12, 12);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(724, 150);
            this.pnl_cadastro.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(530, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 26);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_cpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_cpf.Location = new System.Drawing.Point(301, 34);
            this.tbox_cpf.Mask = "000,000,000-00";
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(204, 22);
            this.tbox_cpf.TabIndex = 1;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_telefone.Location = new System.Drawing.Point(12, 87);
            this.tbox_telefone.Mask = "(00) 00000-0000";
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(270, 22);
            this.tbox_telefone.TabIndex = 2;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_telefone.ForeColor = System.Drawing.Color.Gray;
            this.lbl_telefone.Location = new System.Drawing.Point(14, 63);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(76, 21);
            this.lbl_telefone.TabIndex = 17;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_endereco.ForeColor = System.Drawing.Color.Gray;
            this.lbl_endereco.Location = new System.Drawing.Point(297, 63);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 21);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereço";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(661, 91);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(59, 26);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_endereco.Location = new System.Drawing.Point(301, 87);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(204, 22);
            this.tbox_endereco.TabIndex = 3;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_Adicionar.Location = new System.Drawing.Point(530, 34);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(97, 50);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Salmon;
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(633, 34);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 50);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
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
            this.tbox_nome.Size = new System.Drawing.Size(270, 22);
            this.tbox_nome.TabIndex = 0;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_cpf.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cpf.Location = new System.Drawing.Point(297, 10);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 21);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.listView_funf);
            this.Controls.Add(this.pnl_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.Text = "FormFuncionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_funf;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_cpf;
        private System.Windows.Forms.ColumnHeader ch_telefone;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.Panel pnl_cadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox tbox_cpf;
        private System.Windows.Forms.MaskedTextBox tbox_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.ColumnHeader ch_cargo;
    }
}