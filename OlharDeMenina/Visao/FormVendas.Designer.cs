
namespace OlharDeMenina.Visao
{
    partial class FormVendas
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
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_valortotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_cliente = new System.Windows.Forms.ComboBox();
            this.cbox_formasdepag = new System.Windows.Forms.ComboBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_rs = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.ForeColor = System.Drawing.Color.Gray;
            this.lbl_produtos.Location = new System.Drawing.Point(93, 97);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(103, 28);
            this.lbl_produtos.TabIndex = 11;
            this.lbl_produtos.Text = "Produtos";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cliente.Location = new System.Drawing.Point(93, 30);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(83, 28);
            this.lbl_cliente.TabIndex = 12;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_valortotal
            // 
            this.lbl_valortotal.AutoSize = true;
            this.lbl_valortotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valortotal.ForeColor = System.Drawing.Color.Gray;
            this.lbl_valortotal.Location = new System.Drawing.Point(93, 359);
            this.lbl_valortotal.Name = "lbl_valortotal";
            this.lbl_valortotal.Size = new System.Drawing.Size(137, 31);
            this.lbl_valortotal.TabIndex = 14;
            this.lbl_valortotal.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(416, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Formas de Pagamento";
            // 
            // cbox_cliente
            // 
            this.cbox_cliente.FormattingEnabled = true;
            this.cbox_cliente.Location = new System.Drawing.Point(93, 59);
            this.cbox_cliente.Name = "cbox_cliente";
            this.cbox_cliente.Size = new System.Drawing.Size(253, 21);
            this.cbox_cliente.TabIndex = 18;
            // 
            // cbox_formasdepag
            // 
            this.cbox_formasdepag.FormattingEnabled = true;
            this.cbox_formasdepag.Items.AddRange(new object[] {
            "Dinheiro",
            "Boleto",
            "Pix/Transferência",
            "Cartão de Credito"});
            this.cbox_formasdepag.Location = new System.Drawing.Point(421, 59);
            this.cbox_formasdepag.Name = "cbox_formasdepag";
            this.cbox_formasdepag.Size = new System.Drawing.Size(215, 21);
            this.cbox_formasdepag.TabIndex = 19;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_valor.Location = new System.Drawing.Point(138, 390);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(24, 28);
            this.lbl_valor.TabIndex = 23;
            this.lbl_valor.Text = "0";
            // 
            // lbl_rs
            // 
            this.lbl_rs.AutoSize = true;
            this.lbl_rs.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs.ForeColor = System.Drawing.Color.Gray;
            this.lbl_rs.Location = new System.Drawing.Point(94, 390);
            this.lbl_rs.Name = "lbl_rs";
            this.lbl_rs.Size = new System.Drawing.Size(38, 28);
            this.lbl_rs.TabIndex = 24;
            this.lbl_rs.Text = "R$";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_Adicionar.Location = new System.Drawing.Point(421, 359);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(215, 53);
            this.btn_Adicionar.TabIndex = 25;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Pink;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(93, 130);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(543, 204);
            this.checkedListBox1.TabIndex = 27;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_rs);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.cbox_cliente);
            this.Controls.Add(this.lbl_valortotal);
            this.Controls.Add(this.cbox_formasdepag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbox_formasdepag;
        private System.Windows.Forms.ComboBox cbox_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_valortotal;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_produtos;
        private System.Windows.Forms.Label lbl_rs;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}