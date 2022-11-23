namespace PastelECia.Views
{
    partial class frmTesteBanco
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
            this.dtgTeste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTeste
            // 
            this.dtgTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTeste.Location = new System.Drawing.Point(0, 0);
            this.dtgTeste.Name = "dtgTeste";
            this.dtgTeste.Size = new System.Drawing.Size(800, 450);
            this.dtgTeste.TabIndex = 0;
            // 
            // frmTesteBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgTeste);
            this.Name = "frmTesteBanco";
            this.Text = "frmTesteBanco";
            this.Load += new System.EventHandler(this.frmTesteBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTeste;
    }
}