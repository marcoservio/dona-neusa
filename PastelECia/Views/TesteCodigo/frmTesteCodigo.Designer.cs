namespace PastelECia.Views
{
    partial class frmTesteCodigo
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTeste = new System.Windows.Forms.Button();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtListarNome = new System.Windows.Forms.TextBox();
            this.btnListarNome = new System.Windows.Forms.Button();
            this.lblInativo = new System.Windows.Forms.Label();
            this.cmbInativo = new System.Windows.Forms.ComboBox();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExlcuir = new System.Windows.Forms.Button();
            this.dtgTeste = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(320, 236);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(75, 23);
            this.txtTeste.TabIndex = 24;
            this.txtTeste.Text = "Teste";
            this.txtTeste.UseVisualStyleBackColor = true;
            this.txtTeste.Click += new System.EventHandler(this.txtTeste_Click);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(433, 79);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(174, 20);
            this.txtBuscarId.TabIndex = 23;
            this.txtBuscarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarId_KeyPress);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(469, 113);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(93, 23);
            this.btnBuscarId.TabIndex = 22;
            this.btnBuscarId.Text = "Buscar por Id";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // txtListarNome
            // 
            this.txtListarNome.Location = new System.Drawing.Point(622, 79);
            this.txtListarNome.Name = "txtListarNome";
            this.txtListarNome.Size = new System.Drawing.Size(174, 20);
            this.txtListarNome.TabIndex = 21;
            // 
            // btnListarNome
            // 
            this.btnListarNome.Location = new System.Drawing.Point(658, 113);
            this.btnListarNome.Name = "btnListarNome";
            this.btnListarNome.Size = new System.Drawing.Size(93, 23);
            this.btnListarNome.TabIndex = 20;
            this.btnListarNome.Text = "Listar por Nome";
            this.btnListarNome.UseVisualStyleBackColor = true;
            this.btnListarNome.Click += new System.EventHandler(this.btnListarNome_Click);
            // 
            // lblInativo
            // 
            this.lblInativo.AutoSize = true;
            this.lblInativo.Location = new System.Drawing.Point(35, 189);
            this.lblInativo.Name = "lblInativo";
            this.lblInativo.Size = new System.Drawing.Size(42, 13);
            this.lblInativo.TabIndex = 18;
            this.lblInativo.Text = "Inativo:";
            // 
            // cmbInativo
            // 
            this.cmbInativo.FormattingEnabled = true;
            this.cmbInativo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbInativo.Location = new System.Drawing.Point(112, 181);
            this.cmbInativo.Name = "cmbInativo";
            this.cmbInativo.Size = new System.Drawing.Size(100, 21);
            this.cmbInativo.TabIndex = 17;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(644, 236);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodos.TabIndex = 16;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(725, 236);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(563, 236);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(112, 154);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 13;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(112, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 12;
            this.txtValor.Text = "0,00";
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(112, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Text = "0";
            this.toolTip1.SetToolTip(this.txtId, "Digite o ID do produto");
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(482, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExlcuir
            // 
            this.btnExlcuir.Location = new System.Drawing.Point(401, 236);
            this.btnExlcuir.Name = "btnExlcuir";
            this.btnExlcuir.Size = new System.Drawing.Size(75, 23);
            this.btnExlcuir.TabIndex = 2;
            this.btnExlcuir.Text = "Excluir";
            this.btnExlcuir.UseVisualStyleBackColor = true;
            this.btnExlcuir.Click += new System.EventHandler(this.btnExlcuir_Click);
            // 
            // dtgTeste
            // 
            this.dtgTeste.AllowUserToAddRows = false;
            this.dtgTeste.AllowUserToDeleteRows = false;
            this.dtgTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTeste.Location = new System.Drawing.Point(0, 306);
            this.dtgTeste.Name = "dtgTeste";
            this.dtgTeste.ReadOnly = true;
            this.dtgTeste.Size = new System.Drawing.Size(900, 294);
            this.dtgTeste.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Atenção";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTeste);
            this.panel1.Controls.Add(this.txtBuscarId);
            this.panel1.Controls.Add(this.btnBuscarId);
            this.panel1.Controls.Add(this.txtListarNome);
            this.panel1.Controls.Add(this.btnListarNome);
            this.panel1.Controls.Add(this.lblInativo);
            this.panel1.Controls.Add(this.cmbInativo);
            this.panel1.Controls.Add(this.btnListarTodos);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExlcuir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 306);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTesteCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgTeste);
            this.Controls.Add(this.panel1);
            this.Name = "frmTesteCodigo";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgTeste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtTeste;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtListarNome;
        private System.Windows.Forms.Button btnListarNome;
        private System.Windows.Forms.Label lblInativo;
        private System.Windows.Forms.ComboBox cmbInativo;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExlcuir;
    }
}
