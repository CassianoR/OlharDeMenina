
namespace OlharDeMenina
{
    partial class FormCliente
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
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.tbox_datadenascimento = new System.Windows.Forms.TextBox();
            this.lbl_datadenascimento = new System.Windows.Forms.Label();
            this.tbox_cpf = new System.Windows.Forms.TextBox();
            this.tbox_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_limparC = new System.Windows.Forms.Button();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.btn_AdicionarC = new System.Windows.Forms.Button();
            this.btn_ExcluirC = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.LightPink;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nome,
            this.ch_cpf,
            this.ch_telefone,
            this.ch_endereco});
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(12, 138);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(723, 297);
            this.listView_funf.TabIndex = 17;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 222;
            // 
            // ch_cpf
            // 
            this.ch_cpf.DisplayIndex = 2;
            this.ch_cpf.Text = "CPF";
            this.ch_cpf.Width = 153;
            // 
            // ch_telefone
            // 
            this.ch_telefone.DisplayIndex = 1;
            this.ch_telefone.Text = "Telefone";
            this.ch_telefone.Width = 152;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "Endereço";
            this.ch_endereco.Width = 245;
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Controls.Add(this.tbox_datadenascimento);
            this.pnl_cadastro.Controls.Add(this.lbl_datadenascimento);
            this.pnl_cadastro.Controls.Add(this.tbox_cpf);
            this.pnl_cadastro.Controls.Add(this.tbox_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_limparC);
            this.pnl_cadastro.Controls.Add(this.tbox_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_AdicionarC);
            this.pnl_cadastro.Controls.Add(this.btn_ExcluirC);
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.tbox_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_cpf);
            this.pnl_cadastro.Location = new System.Drawing.Point(12, 12);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(723, 120);
            this.pnl_cadastro.TabIndex = 19;
            // 
            // tbox_datadenascimento
            // 
            this.tbox_datadenascimento.Location = new System.Drawing.Point(320, 87);
            this.tbox_datadenascimento.Name = "tbox_datadenascimento";
            this.tbox_datadenascimento.Size = new System.Drawing.Size(205, 20);
            this.tbox_datadenascimento.TabIndex = 23;
            // 
            // lbl_datadenascimento
            // 
            this.lbl_datadenascimento.AutoSize = true;
            this.lbl_datadenascimento.Location = new System.Drawing.Point(317, 70);
            this.lbl_datadenascimento.Name = "lbl_datadenascimento";
            this.lbl_datadenascimento.Size = new System.Drawing.Size(104, 13);
            this.lbl_datadenascimento.TabIndex = 22;
            this.lbl_datadenascimento.Text = "Data de Nascimento";
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.Location = new System.Drawing.Point(162, 87);
            this.tbox_cpf.MaxLength = 14;
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(126, 20);
            this.tbox_cpf.TabIndex = 21;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.Location = new System.Drawing.Point(12, 83);
            this.tbox_telefone.MaxLength = 11;
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(157, 20);
            this.tbox_telefone.TabIndex = 20;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(15, 70);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 17;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(318, 18);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereço";
            // 
            // btn_limparC
            // 
            this.btn_limpar.Location = new System.Drawing.Point(459, 129);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.Location = new System.Drawing.Point(321, 34);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(204, 20);
            this.tbox_endereco.TabIndex = 8;
            // 
            // btn_AdicionarC
            // 
            this.btn_AdicionarC.BackgroundImage = global::OlharDeMenina.Properties.Resources.adicionar_usuario;
            this.btn_AdicionarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdicionarC.Location = new System.Drawing.Point(655, 15);
            this.btn_AdicionarC.Name = "btn_AdicionarC";
            this.btn_AdicionarC.Size = new System.Drawing.Size(51, 43);
            this.btn_AdicionarC.TabIndex = 13;
            this.btn_AdicionarC.UseVisualStyleBackColor = true;
            this.btn_AdicionarC.Click += new System.EventHandler(this.btn_AdicionarF_Click);
            // 
            // btn_ExcluirC
            // 
            this.btn_ExcluirC.BackgroundImage = global::OlharDeMenina.Properties.Resources.excluir_usuario;
            this.btn_ExcluirC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExcluirC.Location = new System.Drawing.Point(655, 64);
            this.btn_ExcluirC.Name = "btn_ExcluirC";
            this.btn_ExcluirC.Size = new System.Drawing.Size(51, 43);
            this.btn_ExcluirC.TabIndex = 14;
            this.btn_ExcluirC.UseVisualStyleBackColor = true;
            this.btn_ExcluirC.Click += new System.EventHandler(this.btn_ExcluirF_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(15, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(18, 34);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(270, 20);
            this.tbox_nome.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(159, 70);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // button1
            // 
            this.tbox_datadenascimento.Location = new System.Drawing.Point(320, 87);
            this.tbox_datadenascimento.Name = "tbox_datadenascimento";
            this.tbox_datadenascimento.Size = new System.Drawing.Size(205, 20);
            this.tbox_datadenascimento.TabIndex = 23;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(759, 468);
            this.Controls.Add(this.listView_funf);
            this.Controls.Add(this.pnl_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
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
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_limparC;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.Button btn_AdicionarC;
        private System.Windows.Forms.Button btn_ExcluirC;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox tbox_cpf;
        private System.Windows.Forms.TextBox tbox_telefone;
        private System.Windows.Forms.TextBox tbox_datadenascimento;
        private System.Windows.Forms.Label lbl_datadenascimento;
    }
}