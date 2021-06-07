
namespace OlharDeMenina.Visao
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_nome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nome.Location = new System.Drawing.Point(68, 72);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 21);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "nome";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_senha.ForeColor = System.Drawing.Color.Gray;
            this.lbl_senha.Location = new System.Drawing.Point(68, 108);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(55, 21);
            this.lbl_senha.TabIndex = 11;
            this.lbl_senha.Text = "senha";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_cargo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cargo.Location = new System.Drawing.Point(68, 144);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(53, 21);
            this.lbl_cargo.TabIndex = 12;
            this.lbl_cargo.Text = "cargo";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_cpf.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cpf.Location = new System.Drawing.Point(68, 178);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 21);
            this.lbl_cpf.TabIndex = 13;
            this.lbl_cpf.Text = "cpf";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_telefone.ForeColor = System.Drawing.Color.Gray;
            this.lbl_telefone.Location = new System.Drawing.Point(68, 208);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(73, 21);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "telefone";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_endereco.ForeColor = System.Drawing.Color.Gray;
            this.lbl_endereco.Location = new System.Drawing.Point(68, 238);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 21);
            this.lbl_endereco.TabIndex = 15;
            this.lbl_endereco.Text = "endereco";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(522, 432);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuario";
            this.Text = "Seus dados";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
    }
}