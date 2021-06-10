
namespace OlharDeMenina
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnHist = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnVisao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(48, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Visão Geral";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(184, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 462);
            this.panel3.TabIndex = 7;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pnlSuperior.Controls.Add(this.panel4);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(935, 35);
            this.pnlSuperior.TabIndex = 8;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btmin);
            this.panel4.Controls.Add(this.btnmax);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(826, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 35);
            this.panel4.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::OlharDeMenina.Properties.Resources.closebtnn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(73, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btmin
            // 
            this.btmin.BackColor = System.Drawing.Color.Transparent;
            this.btmin.BackgroundImage = global::OlharDeMenina.Properties.Resources.minbtn;
            this.btmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Location = new System.Drawing.Point(9, 6);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(28, 23);
            this.btmin.TabIndex = 8;
            this.btmin.UseVisualStyleBackColor = false;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.BackgroundImage = global::OlharDeMenina.Properties.Resources.Maxbtn;
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.Location = new System.Drawing.Point(43, 6);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(24, 23);
            this.btnmax.TabIndex = 7;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblTitulo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 41);
            this.panel6.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnHist);
            this.panel1.Controls.Add(this.btnFunc);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.btnVisao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 352);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 152);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 318);
            this.pnlNav.TabIndex = 3;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnClientes.Location = new System.Drawing.Point(0, 265);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(184, 53);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.Leave += new System.EventHandler(this.btnClientes_Leave);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnEstoque.Location = new System.Drawing.Point(0, 212);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(184, 53);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            this.btnEstoque.Leave += new System.EventHandler(this.btnEstoque_Leave);
            // 
            // btnHist
            // 
            this.btnHist.BackColor = System.Drawing.Color.Transparent;
            this.btnHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHist.FlatAppearance.BorderSize = 0;
            this.btnHist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnHist.Location = new System.Drawing.Point(0, 159);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(184, 53);
            this.btnHist.TabIndex = 2;
            this.btnHist.Text = "Histórico";
            this.btnHist.UseVisualStyleBackColor = false;
            this.btnHist.Click += new System.EventHandler(this.btnHist_Click);
            this.btnHist.Leave += new System.EventHandler(this.btnHist_Leave);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnFunc.Location = new System.Drawing.Point(0, 106);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(184, 53);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.Text = "Funcionários";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            this.btnFunc.Leave += new System.EventHandler(this.btnFunc_Leave);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnVendas.Location = new System.Drawing.Point(0, 53);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(184, 53);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            this.btnVendas.Leave += new System.EventHandler(this.btnVendas_Leave);
            // 
            // btnVisao
            // 
            this.btnVisao.BackColor = System.Drawing.Color.Transparent;
            this.btnVisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisao.FlatAppearance.BorderSize = 0;
            this.btnVisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnVisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.btnVisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisao.Location = new System.Drawing.Point(0, 0);
            this.btnVisao.Name = "btnVisao";
            this.btnVisao.Size = new System.Drawing.Size(184, 53);
            this.btnVisao.TabIndex = 2;
            this.btnVisao.Text = "Visão Geral";
            this.btnVisao.UseVisualStyleBackColor = false;
            this.btnVisao.Click += new System.EventHandler(this.btnVisao_Click);
            this.btnVisao.Leave += new System.EventHandler(this.btnVisao_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(130)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 151);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(70)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(0, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 503);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(184, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(751, 41);
            this.panel9.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::OlharDeMenina.Properties.Resources.fundo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olhar de Menina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVisao;
        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

