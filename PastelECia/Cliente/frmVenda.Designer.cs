namespace PastelECia.Cliente
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
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVenda
            // 
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Location = new System.Drawing.Point(12, 251);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.Size = new System.Drawing.Size(776, 187);
            this.dtgVenda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(50, 50);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(53, 80);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(427, 172);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "button1";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(670, 13);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "button1";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgVenda);
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnImprimir;
    }
}