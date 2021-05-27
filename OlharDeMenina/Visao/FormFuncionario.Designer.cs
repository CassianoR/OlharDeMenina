
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
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_ExcluirF = new System.Windows.Forms.Button();
            this.btn_limparF = new System.Windows.Forms.Button();
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.tbox_cpf = new System.Windows.Forms.TextBox();
            this.tbox_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.btn_AdicionarF = new System.Windows.Forms.Button();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.LightPink;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_nome,
            this.ch_telefone,
            this.ch_cpf,
            this.ch_endereco});
            this.listView_funf.FullRowSelect = true;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(12, 138);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(723, 297);
            this.listView_funf.TabIndex = 0;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_id
            // 
            this.ch_id.Text = "ID";
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 247;
            // 


            // 
            this.ch_id.Text = "ID";
            this.ch_id.Width = 37;
            // 
            // ch_telefone
            // 
            this.ch_telefone.Text = "Telefone";
            this.ch_telefone.Width = 114;
            // 
            // ch_cpf
            // 
            this.ch_cpf.Text = "CPF";
            this.ch_cpf.Width = 140;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "Endereço";
            this.ch_endereco.Width = 245;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(18, 87);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(307, 20);
            this.tbox_nome.TabIndex = 5;
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.Location = new System.Drawing.Point(18, 34);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(307, 20);
            this.tbox_endereco.TabIndex = 8;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(15, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(360, 71);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(15, 70);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereço";
            this.lbl_endereco.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_ExcluirF
            // 
            this.btn_ExcluirF.BackgroundImage = global::OlharDeMenina.Properties.Resources.excluir_usuario;
            this.btn_ExcluirF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExcluirF.Location = new System.Drawing.Point(655, 64);
            this.btn_ExcluirF.Name = "btn_ExcluirF";
            this.btn_ExcluirF.Size = new System.Drawing.Size(51, 43);
            this.btn_ExcluirF.TabIndex = 21;
            this.btn_ExcluirF.Click += new System.EventHandler(this.btn_ExcluirF_Click);
            // 
            // btn_limparF
            // 
            this.btn_limparF.BackColor = System.Drawing.Color.Transparent;
            this.btn_limparF.BackgroundImage = global::OlharDeMenina.Properties.Resources.borracha;
            this.btn_limparF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limparF.Location = new System.Drawing.Point(560, 52);
            this.btn_limparF.Name = "btn_limparF";
            this.btn_limparF.Size = new System.Drawing.Size(41, 38);
            this.btn_limparF.TabIndex = 20;
            this.btn_limparF.UseVisualStyleBackColor = false;
            this.btn_limparF.Click += new System.EventHandler(this.btn_limparF_Click);



            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Controls.Add(this.btn_AdicionarF);
            this.pnl_cadastro.Controls.Add(this.tbox_cpf);
            this.pnl_cadastro.Controls.Add(this.tbox_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_telefone);
            this.pnl_cadastro.Controls.Add(this.btn_limparF);
            this.pnl_cadastro.Controls.Add(this.lbl_endereco);
            this.pnl_cadastro.Controls.Add(this.tbox_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_ExcluirF);
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.tbox_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_cpf);
            this.pnl_cadastro.Location = new System.Drawing.Point(12, 12);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(723, 120);
            this.pnl_cadastro.TabIndex = 16;
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.Location = new System.Drawing.Point(363, 87);
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(139, 20);
            this.tbox_cpf.TabIndex = 19;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.Location = new System.Drawing.Point(363, 34);
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(139, 20);
            this.tbox_telefone.TabIndex = 18;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(360, 18);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 17;
            this.lbl_telefone.Text = "Telefone";
            // 
            // btn_AdicionarF
            // 
            this.btn_AdicionarF.BackgroundImage = global::OlharDeMenina.Properties.Resources.adicionar_usuario;
            this.btn_AdicionarF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdicionarF.Location = new System.Drawing.Point(655, 15);
            this.btn_AdicionarF.Name = "btn_AdicionarF";
            this.btn_AdicionarF.Size = new System.Drawing.Size(51, 43);
            this.btn_AdicionarF.TabIndex = 22;
            this.btn_AdicionarF.UseVisualStyleBackColor = true;
            this.btn_AdicionarF.Click += new System.EventHandler(this.btn_AdicionarF_Click);
            // 

            // button1
            // 
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_ExcluirF;
        private System.Windows.Forms.Button btn_limparF;
        private System.Windows.Forms.Panel pnl_cadastro;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_cpf;
        private System.Windows.Forms.ColumnHeader ch_telefone;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.TextBox tbox_cpf;
        private System.Windows.Forms.TextBox tbox_telefone;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.Button btn_AdicionarF;
    }
}