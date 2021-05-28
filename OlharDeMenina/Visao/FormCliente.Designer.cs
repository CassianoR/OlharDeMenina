
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_cadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.White;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nome,
            this.ch_cpf,
            this.ch_telefone,
            this.ch_endereco});
            this.listView_funf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(0, 188);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(748, 268);
            this.listView_funf.TabIndex = 17;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 164;
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
            this.ch_endereco.Width = 224;
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Controls.Add(this.panel2);
            this.pnl_cadastro.Controls.Add(this.panel1);
            this.pnl_cadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cadastro.Location = new System.Drawing.Point(0, 0);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(748, 171);
            this.pnl_cadastro.TabIndex = 19;
            // 
            // tbox_datadenascimento
            // 
            this.tbox_datadenascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_datadenascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_datadenascimento.Location = new System.Drawing.Point(309, 100);
            this.tbox_datadenascimento.Name = "tbox_datadenascimento";
            this.tbox_datadenascimento.Size = new System.Drawing.Size(205, 22);
            this.tbox_datadenascimento.TabIndex = 23;
            // 
            // lbl_datadenascimento
            // 
            this.lbl_datadenascimento.AutoSize = true;
            this.lbl_datadenascimento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_datadenascimento.ForeColor = System.Drawing.Color.Gray;
            this.lbl_datadenascimento.Location = new System.Drawing.Point(305, 77);
            this.lbl_datadenascimento.Name = "lbl_datadenascimento";
            this.lbl_datadenascimento.Size = new System.Drawing.Size(166, 21);
            this.lbl_datadenascimento.TabIndex = 22;
            this.lbl_datadenascimento.Text = "Data de Nascimento";
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_cpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_cpf.Location = new System.Drawing.Point(177, 100);
            this.tbox_cpf.MaxLength = 14;
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(126, 22);
            this.tbox_cpf.TabIndex = 21;
            // 
            // tbox_telefone
            // 
            this.tbox_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_telefone.Location = new System.Drawing.Point(12, 100);
            this.tbox_telefone.MaxLength = 11;
            this.tbox_telefone.Name = "tbox_telefone";
            this.tbox_telefone.Size = new System.Drawing.Size(157, 22);
            this.tbox_telefone.TabIndex = 20;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_telefone.ForeColor = System.Drawing.Color.Gray;
            this.lbl_telefone.Location = new System.Drawing.Point(12, 76);
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
            this.lbl_endereco.Location = new System.Drawing.Point(305, 24);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 21);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereço";
            // 
            // btn_limparC
            // 
            this.btn_limparC.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_limparC.FlatAppearance.BorderSize = 0;
            this.btn_limparC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparC.ForeColor = System.Drawing.Color.White;
            this.btn_limparC.Location = new System.Drawing.Point(138, 96);
            this.btn_limparC.Name = "btn_limparC";
            this.btn_limparC.Size = new System.Drawing.Size(59, 26);
            this.btn_limparC.TabIndex = 24;
            this.btn_limparC.Text = "Limpar";
            this.btn_limparC.UseVisualStyleBackColor = false;
            this.btn_limparC.Click += new System.EventHandler(this.btn_limparC_Click);
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_endereco.Location = new System.Drawing.Point(308, 48);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(204, 22);
            this.tbox_endereco.TabIndex = 8;
            // 
            // btn_AdicionarC
            // 
            this.btn_AdicionarC.BackColor = System.Drawing.Color.Turquoise;
            this.btn_AdicionarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdicionarC.FlatAppearance.BorderSize = 0;
            this.btn_AdicionarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdicionarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarC.ForeColor = System.Drawing.Color.White;
            this.btn_AdicionarC.Location = new System.Drawing.Point(7, 39);
            this.btn_AdicionarC.Name = "btn_AdicionarC";
            this.btn_AdicionarC.Size = new System.Drawing.Size(97, 50);
            this.btn_AdicionarC.TabIndex = 13;
            this.btn_AdicionarC.Text = "Adicionar";
            this.btn_AdicionarC.UseVisualStyleBackColor = false;
            this.btn_AdicionarC.Click += new System.EventHandler(this.btn_AdicionarF_Click);
            // 
            // btn_ExcluirC
            // 
            this.btn_ExcluirC.BackColor = System.Drawing.Color.Salmon;
            this.btn_ExcluirC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExcluirC.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirC.ForeColor = System.Drawing.Color.White;
            this.btn_ExcluirC.Location = new System.Drawing.Point(110, 39);
            this.btn_ExcluirC.Name = "btn_ExcluirC";
            this.btn_ExcluirC.Size = new System.Drawing.Size(87, 50);
            this.btn_ExcluirC.TabIndex = 14;
            this.btn_ExcluirC.Text = "Excluir";
            this.btn_ExcluirC.UseVisualStyleBackColor = false;
            this.btn_ExcluirC.Click += new System.EventHandler(this.btn_ExcluirF_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_nome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nome.Location = new System.Drawing.Point(12, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(57, 21);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            // 
            // tbox_nome
            // 
            this.tbox_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_nome.Location = new System.Drawing.Point(12, 53);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(270, 22);
            this.tbox_nome.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_cpf.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cpf.Location = new System.Drawing.Point(173, 76);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 21);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(7, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 26);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btn_ExcluirC);
            this.panel1.Controls.Add(this.btn_AdicionarC);
            this.panel1.Controls.Add(this.btn_limparC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(548, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 171);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbox_datadenascimento);
            this.panel2.Controls.Add(this.lbl_datadenascimento);
            this.panel2.Controls.Add(this.lbl_nome);
            this.panel2.Controls.Add(this.tbox_cpf);
            this.panel2.Controls.Add(this.tbox_nome);
            this.panel2.Controls.Add(this.lbl_endereco);
            this.panel2.Controls.Add(this.lbl_telefone);
            this.panel2.Controls.Add(this.tbox_endereco);
            this.panel2.Controls.Add(this.tbox_telefone);
            this.panel2.Controls.Add(this.lbl_cpf);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 171);
            this.panel2.TabIndex = 27;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.listView_funf);
            this.Controls.Add(this.pnl_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.pnl_cadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}