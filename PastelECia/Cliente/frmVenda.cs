using PastelECia.Relatorios;
using PastelECia.VO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            lstProdutos.Add(produto);

            ResetGrid();

            dtgVenda.DataSource = lstProdutos;
        }

        private void ResetGrid()
        {
            dtgVenda.DataSource = null;
            dtgVenda.Update();
            dtgVenda.Refresh();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            double valorTotal = lstProdutos.Sum(p => p.ValorTotal);
            var venda = new Venda();
            venda.ValorTotalVenda = valorTotal;

            var dt = GerarDados();
            frmRelNotaVenda frm = new frmRelNotaVenda(dt);
            frm.ShowDialog();
        }

        private DataTable GerarDados()
        {
            var dt = new DataTable();

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

            double valorTotal = lstProdutos.Sum(p => p.ValorTotal);
            dt.Rows.Add("", "", "Valor Total Venda: ", valorTotal);

            return dt;
        }
    }
}
