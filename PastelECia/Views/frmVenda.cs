using PastelECia.Relatorios;
using PastelECia.VO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PastelECia.Cliente
{
    public partial class frmVenda : Form
    {
        private List<Produto> lstProdutos = new List<Produto>();

        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            ResetGrid();
            LimparCampos();
            CarregarComboProdutos();
        }

        private void CarregarComboProdutos()
        {
            try
            {
                cmbProdutos.DataSource = new Produto().Produtos();
                cmbProdutos.DisplayMember = "Produto";
                cmbProdutos.ValueMember = "Nome";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparCampos()
        {
            txtQuantidade.Text = string.Empty;
            cmbProdutos.Items.Clear();
        }

        private void ResetGrid()
        {
            dtgVenda.DataSource = null;
            dtgVenda.Update();
            dtgVenda.Refresh();
        }

        private void ControleCampos(bool ativado)
        {
            btnImprimir.Enabled = ativado;
            btnExcluir.Enabled = ativado;
            txtQuantidade.Text = string.Empty;
        }

        private void CarregaGrid(List<Produto> produtos)
        {
            ResetGrid();
            if(produtos.Count > 0)
            {
                dtgVenda.DataSource = lstProdutos;
                this.dtgVenda.Columns["Id"].Visible = false;
            }
            else
            {
                ControleCampos(false);
                cmbProdutos.SelectedIndex = 0;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtQuantidade.Text == string.Empty)
                    throw new Exception("Digite uma quantidade.");

                Produto produto = new Produto();
                Produto combo = (Produto) cmbProdutos.SelectedItem;

                produto.Id++;
                produto.Nome = combo.Nome;
                produto.Valor = combo.Valor;
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                lstProdutos.Add(produto);

                CarregaGrid(lstProdutos);

                ControleCampos(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDados();
            frmRelNotaVenda frm = new frmRelNotaVenda(dt);
            frm.ShowDialog();
        }

        private DataTable GerarDados()
        {
            var dt = new DataTable();

            try
            {
                dt.Columns.Add("Nome");
                dt.Columns.Add("Quantidade");
                dt.Columns.Add("Valor");
                dt.Columns.Add("ValorTotal");
                dt.Columns.Add("ValorTotalVenda");

                foreach(DataGridViewRow item in dtgVenda.Rows)
                {
                    dt.Rows.Add(item.Cells["Nome"].Value.ToString(), item.Cells["Quantidade"].Value.ToString(), Convert.ToDecimal(item.Cells["Valor"].Value.ToString()), Convert.ToDecimal(item.Cells["ValorTotal"].Value.ToString()));
                }

                dt.Rows.Add("", "", "", "");

                decimal valorTotal = lstProdutos.Sum(p => p.ValorTotal);
                dt.Rows.Add("", "", "Valor Total Venda: ", Math.Round(Convert.ToDecimal(valorTotal), 2));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return dt;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtgVenda.CurrentRow == null)
                    throw new Exception("Clique um item da tabela para excluir");

                lstProdutos.RemoveAt(dtgVenda.CurrentRow.Index);

                CarregaGrid(lstProdutos);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
