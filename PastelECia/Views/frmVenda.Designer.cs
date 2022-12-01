namespace PastelECia.Views
{
    partial class frmVenda
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimapr = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValorTotalVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVenda
            // 
            this.dtgVenda.AllowUserToAddRows = false;
            this.dtgVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVenda.Location = new System.Drawing.Point(0, 205);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.ReadOnly = true;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVenda.Size = new System.Drawing.Size(715, 431);
            this.dtgVenda.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(208, 107);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(498, 26);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(3, 113);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(107, 20);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(493, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(126, 38);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(7, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 38);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(208, 62);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(498, 28);
            this.cmbProdutos.TabIndex = 1;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(3, 70);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(86, 20);
            this.lblProdutos.TabIndex = 10;
            this.lblProdutos.Text = "Produtos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 205);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLimapr);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnCalculadora);
            this.panel3.Controls.Add(this.btnAdicionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 46);
            this.panel3.TabIndex = 1;
            // 
            // btnLimapr
            // 
            this.btnLimapr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimapr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimapr.Image = ((System.Drawing.Image)(resources.GetObject("btnLimapr.Image")));
            this.btnLimapr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimapr.Location = new System.Drawing.Point(386, 4);
            this.btnLimapr.Name = "btnLimapr";
            this.btnLimapr.Size = new System.Drawing.Size(101, 38);
            this.btnLimapr.TabIndex = 8;
            this.btnLimapr.Text = "&Limpar";
            this.btnLimapr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimapr.UseVisualStyleBackColor = true;
            this.btnLimapr.Click += new System.EventHandler(this.btnLimapr_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(625, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 38);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(279, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 38);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(131, 4);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(142, 38);
            this.btnCalculadora.TabIndex = 6;
            this.btnCalculadora.Text = "&Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCliente);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblProdutos);
            this.panel4.Controls.Add(this.txtQuantidade);
            this.panel4.Controls.Add(this.cmbProdutos);
            this.panel4.Controls.Add(this.lblQuantidade);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 158);
            this.panel4.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(208, 18);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(498, 26);
            this.txtCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValorTotalVenda);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 41);
            this.panel2.TabIndex = 12;
            // 
            // txtValorTotalVenda
            // 
            this.txtValorTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotalVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalVenda.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtValorTotalVenda.Location = new System.Drawing.Point(518, 7);
            this.txtValorTotalVenda.Name = "txtValorTotalVenda";
            this.txtValorTotalVenda.ReadOnly = true;
            this.txtValorTotalVenda.Size = new System.Drawing.Size(185, 26);
            this.txtValorTotalVenda.TabIndex = 10;
            this.txtValorTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Total Venda:";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgVenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dona Neusa";
            this.Activated += new System.EventHandler(this.frmVenda_Activated);
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValorTotalVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimapr;
    }
}