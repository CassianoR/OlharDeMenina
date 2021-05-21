
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
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pbl_titulo = new System.Windows.Forms.Panel();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_AdicionarF = new System.Windows.Forms.Button();
            this.btn_ExcluirF = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.tbox_cpf = new System.Windows.Forms.TextBox();
            this.tbox_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbl_titulo.SuspendLayout();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.LightPink;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_nome,
            this.ch_telefone,
            this.ch_cpf,
            this.ch_endereco});
            this.listView_funf.FullRowSelect = true;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(12, 259);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(726, 185);
            this.listView_funf.TabIndex = 0;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 247;
            // 
            // ch_cpf
            // 
            this.ch_cpf.Text = "CPF";
            this.ch_cpf.Width = 140;
            // 
            // ch_telefone
            // 
            this.ch_telefone.Text = "Telefone";
            this.ch_telefone.Width = 114;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "Endereço";
            this.ch_endereco.Width = 245;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(41, 16);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(107, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Lista de Funcionários";
            // 
            // pbl_titulo
            // 
            this.pbl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbl_titulo.Controls.Add(this.lbl_Titulo);
            this.pbl_titulo.Location = new System.Drawing.Point(292, 12);
            this.pbl_titulo.Name = "pbl_titulo";
            this.pbl_titulo.Size = new System.Drawing.Size(191, 44);
            this.pbl_titulo.TabIndex = 4;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(12, 31);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(307, 20);
            this.tbox_nome.TabIndex = 5;
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.Location = new System.Drawing.Point(12, 132);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(307, 20);
            this.tbox_endereco.TabIndex = 8;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(9, 12);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(177, 67);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(9, 116);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereço";
            this.lbl_endereco.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_AdicionarF
            // 
            this.btn_AdicionarF.Location = new System.Drawing.Point(377, 28);
            this.btn_AdicionarF.Name = "btn_AdicionarF";
            this.btn_AdicionarF.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarF.TabIndex = 13;
            this.btn_AdicionarF.Text = "Adicionar";
            this.btn_AdicionarF.UseVisualStyleBackColor = true;
            this.btn_AdicionarF.Click += new System.EventHandler(this.btn_AdicionarF_Click);
            // 
            // btn_ExcluirF
            // 
            this.btn_ExcluirF.Location = new System.Drawing.Point(377, 80);
            this.btn_ExcluirF.Name = "btn_ExcluirF";
            this.btn_ExcluirF.Size = new System.Drawing.Size(75, 23);
            this.btn_ExcluirF.TabIndex = 14;
            this.btn_ExcluirF.Text = "Excluir";
            this.btn_ExcluirF.UseVisualStyleBackColor = true;
            this.btn_ExcluirF.Click += new System.EventHandler(this.btn_ExcluirF_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(399, 129);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(53, 23);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cadastro.Controls.Add(this.tbox_cpf);
            this.pnl_cadastro.Controls.Add(this.tbox_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_telefone);
            this.pnl_cadastro.Controls.Add(this.lbl_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_limpar);
            this.pnl_cadastro.Controls.Add(this.tbox_endereco);
            this.pnl_cadastro.Controls.Add(this.btn_AdicionarF);
            this.pnl_cadastro.Controls.Add(this.btn_ExcluirF);
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.tbox_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_cpf);
            this.pnl_cadastro.Location = new System.Drawing.Point(145, 62);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(486, 185);
            this.pnl_cadastro.TabIndex = 16;
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.Location = new System.Drawing.Point(180, 83);
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(139, 20);
            this.tbox_cpf.TabIndex = 19;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.Location = new System.Drawing.Point(12, 83);
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(157, 20);
            this.tbox_telefone.TabIndex = 18;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(9, 67);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 17;
            this.lbl_telefone.Text = "Telefone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ch_id
            // 
            this.ch_id.Text = "ID";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(750, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_funf);
            this.Controls.Add(this.pbl_titulo);
            this.Controls.Add(this.pnl_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.Text = "FormFuncionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.pbl_titulo.ResumeLayout(false);
            this.pbl_titulo.PerformLayout();
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_funf;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel pbl_titulo;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_AdicionarF;
        private System.Windows.Forms.Button btn_ExcluirF;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Panel pnl_cadastro;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_cpf;
        private System.Windows.Forms.ColumnHeader ch_telefone;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.TextBox tbox_cpf;
        private System.Windows.Forms.TextBox tbox_telefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ch_id;
    }
}