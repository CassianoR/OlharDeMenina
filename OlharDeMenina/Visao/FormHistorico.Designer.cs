
namespace OlharDeMenina.Visao
{
    partial class FormHistorico
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
            this.ch_codigodavenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_codigocliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_metododepagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_dataehora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tbox_codigovenda = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_codigocliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_idfuncionario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_funf
            // 
            this.listView_funf.BackColor = System.Drawing.Color.White;
            this.listView_funf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_funf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_codigodavenda,
            this.ch_id,
            this.ch_codigocliente,
            this.ch_valor,
            this.ch_metododepagamento,
            this.ch_dataehora});
            this.listView_funf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_funf.FullRowSelect = true;
            this.listView_funf.HideSelection = false;
            this.listView_funf.Location = new System.Drawing.Point(0, 110);
            this.listView_funf.Name = "listView_funf";
            this.listView_funf.Size = new System.Drawing.Size(748, 346);
            this.listView_funf.TabIndex = 22;
            this.listView_funf.UseCompatibleStateImageBehavior = false;
            this.listView_funf.View = System.Windows.Forms.View.Details;
            // 
            // ch_codigodavenda
            // 
            this.ch_codigodavenda.Text = "Código da Venda";
            this.ch_codigodavenda.Width = 102;
            // 
            // ch_id
            // 
            this.ch_id.Text = "ID";
            this.ch_id.Width = 94;
            // 
            // ch_codigocliente
            // 
            this.ch_codigocliente.Text = "Código Cliente";
            this.ch_codigocliente.Width = 122;
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
            this.ch_valor.Width = 70;
            // 
            // ch_metododepagamento
            // 
            this.ch_metododepagamento.Text = "Método de Pagamento";
            this.ch_metododepagamento.Width = 173;
            // 
            // ch_dataehora
            // 
            this.ch_dataehora.Text = "Data e Hora";
            this.ch_dataehora.Width = 186;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(417, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbox_codigovenda
            // 
            this.tbox_codigovenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_codigovenda.Location = new System.Drawing.Point(19, 36);
            this.tbox_codigovenda.Multiline = true;
            this.tbox_codigovenda.Name = "tbox_codigovenda";
            this.tbox_codigovenda.Size = new System.Drawing.Size(132, 20);
            this.tbox_codigovenda.TabIndex = 24;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lbl_marca.ForeColor = System.Drawing.Color.Gray;
            this.lbl_marca.Location = new System.Drawing.Point(506, 13);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(123, 21);
            this.lbl_marca.TabIndex = 25;
            this.lbl_marca.Text = "Código Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código Venda";
            // 
            // tbox_codigocliente
            // 
            this.tbox_codigocliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_codigocliente.Location = new System.Drawing.Point(510, 36);
            this.tbox_codigocliente.Multiline = true;
            this.tbox_codigocliente.Name = "tbox_codigocliente";
            this.tbox_codigocliente.Size = new System.Drawing.Size(132, 20);
            this.tbox_codigocliente.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(162, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 20);
            this.button2.TabIndex = 26;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(258, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID do Funcionário";
            // 
            // tbox_idfuncionario
            // 
            this.tbox_idfuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_idfuncionario.Location = new System.Drawing.Point(262, 36);
            this.tbox_idfuncionario.Multiline = true;
            this.tbox_idfuncionario.Name = "tbox_idfuncionario";
            this.tbox_idfuncionario.Size = new System.Drawing.Size(143, 20);
            this.tbox_idfuncionario.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(653, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 29;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_idfuncionario);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tbox_codigovenda);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_marca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbox_codigocliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 77);
            this.panel1.TabIndex = 33;
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView_funf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorico";
            this.Text = "FormHistorico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_funf;
        private System.Windows.Forms.ColumnHeader ch_codigodavenda;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.ColumnHeader ch_codigocliente;
        private System.Windows.Forms.ColumnHeader ch_valor;
        private System.Windows.Forms.ColumnHeader ch_metododepagamento;
        private System.Windows.Forms.ColumnHeader ch_dataehora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox_codigovenda;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_codigocliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_idfuncionario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}