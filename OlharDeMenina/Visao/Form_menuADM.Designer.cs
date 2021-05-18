
namespace OlharDeMenina.Visao
{
    partial class Form_menuADM
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnHist = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVisaoGeral = new System.Windows.Forms.Button();
            this.pnlInicial = new System.Windows.Forms.Panel();
            this.tbRelogio = new System.Windows.Forms.TextBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.pblavisos = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msmenu = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.pnlInicial.SuspendLayout();
            this.pblavisos.SuspendLayout();
            this.msmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnHist);
            this.pnlMenu.Controls.Add(this.btnVendas);
            this.pnlMenu.Controls.Add(this.btnEstoque);
            this.pnlMenu.Controls.Add(this.btnVisaoGeral);
            this.pnlMenu.Location = new System.Drawing.Point(12, 44);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(174, 400);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(-1, 323);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(174, 76);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnHist
            // 
            this.btnHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHist.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHist.Location = new System.Drawing.Point(-1, 242);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(174, 82);
            this.btnHist.TabIndex = 3;
            this.btnHist.Text = "Histórico";
            this.btnHist.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(-1, 161);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(174, 82);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(-1, 80);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(174, 82);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnVisaoGeral
            // 
            this.btnVisaoGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisaoGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisaoGeral.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisaoGeral.Location = new System.Drawing.Point(-1, -1);
            this.btnVisaoGeral.Name = "btnVisaoGeral";
            this.btnVisaoGeral.Size = new System.Drawing.Size(174, 87);
            this.btnVisaoGeral.TabIndex = 0;
            this.btnVisaoGeral.Text = "Visão Geral";
            this.btnVisaoGeral.UseVisualStyleBackColor = true;
            this.btnVisaoGeral.Click += new System.EventHandler(this.btnVisaoGeral_Click);
            // 
            // pnlInicial
            // 
            this.pnlInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInicial.Controls.Add(this.tbRelogio);
            this.pnlInicial.Controls.Add(this.Calendario);
            this.pnlInicial.Controls.Add(this.pblavisos);
            this.pnlInicial.Controls.Add(this.lblTitulo);
            this.pnlInicial.Location = new System.Drawing.Point(184, 44);
            this.pnlInicial.Name = "pnlInicial";
            this.pnlInicial.Size = new System.Drawing.Size(604, 400);
            this.pnlInicial.TabIndex = 6;
            // 
            // tbRelogio
            // 
            this.tbRelogio.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbRelogio.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRelogio.Location = new System.Drawing.Point(506, 7);
            this.tbRelogio.MaxLength = 5;
            this.tbRelogio.Name = "tbRelogio";
            this.tbRelogio.ReadOnly = true;
            this.tbRelogio.Size = new System.Drawing.Size(89, 26);
            this.tbRelogio.TabIndex = 7;
            this.tbRelogio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(371, 232);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 8;
            // 
            // pblavisos
            // 
            this.pblavisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblavisos.Controls.Add(this.listBox1);
            this.pblavisos.Controls.Add(this.lblAvisos);
            this.pblavisos.Location = new System.Drawing.Point(14, 80);
            this.pblavisos.Name = "pblavisos";
            this.pblavisos.Size = new System.Drawing.Size(345, 315);
            this.pblavisos.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisos.Location = new System.Drawing.Point(144, 11);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(53, 21);
            this.lblAvisos.TabIndex = 0;
            this.lblAvisos.Text = "Avisos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(3, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 26);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Visão Geral";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msmenu
            // 
            this.msmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.minimizarToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.msmenu.Location = new System.Drawing.Point(0, 0);
            this.msmenu.Name = "msmenu";
            this.msmenu.Size = new System.Drawing.Size(800, 34);
            this.msmenu.TabIndex = 7;
            this.msmenu.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 30);
            this.sairToolStripMenuItem.Text = "X";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem1
            // 
            this.minimizarToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizarToolStripMenuItem1.Name = "minimizarToolStripMenuItem1";
            this.minimizarToolStripMenuItem1.Size = new System.Drawing.Size(24, 30);
            this.minimizarToolStripMenuItem1.Text = "_";
            this.minimizarToolStripMenuItem1.Click += new System.EventHandler(this.minimizarToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // Form_menuADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInicial);
            this.Controls.Add(this.msmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msmenu;
            this.Name = "Form_menuADM";
            this.Text = "Menu ADM";
            this.pnlMenu.ResumeLayout(false);
            this.pnlInicial.ResumeLayout(false);
            this.pnlInicial.PerformLayout();
            this.pblavisos.ResumeLayout(false);
            this.pblavisos.PerformLayout();
            this.msmenu.ResumeLayout(false);
            this.msmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVisaoGeral;
        private System.Windows.Forms.Panel pnlInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbRelogio;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel pblavisos;
        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip msmenu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem1;
    }
}