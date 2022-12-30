using PastelECia.Dados.EfCore;
using PastelECia.Dados.EfCore.Utilitarios;
using PastelECia.Views.Cadastro;
using PastelECia.Views.Movimentacao;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void ApagaAba(TabPage tabPage)
        {
            if (!(tabPage == null))
            {
                tbcAplicacoes.TabPages.Remove(tabPage);
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            sobre.Dispose();
        }

        private void testeAncestralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAncestral f = new frmAncestral();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Teste Ancestral";
            tb.Text = "Teste Ancestral";
            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
            tbcAplicacoes.SelectedTab = tb;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Cadastro Produto";
            tb.Text = "Cadastro Produto";
            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
            tbcAplicacoes.SelectedTab = tb;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaNew f = new frmVendaNew();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Venda";
            tb.Text = "Venda";
            tb.ImageIndex = 1;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
            tbcAplicacoes.SelectedTab = tb;
        }

        private void tbcAplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ApagaAba(tbcAplicacoes.SelectedTab);
            }
        }

        private void conectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void testeConexãoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ConnectionTest.Test();
                MessageBox.Show("Conectado com sucesso", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
