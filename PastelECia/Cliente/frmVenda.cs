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
        List<Produto> lstProdutos = new List<Produto>();

        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            var total = Convert.ToInt32(txtValor.Text) * Convert.ToInt32(txtQuantidade.Text);
            var produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Valor = Convert.ToInt32(txtValor.Text);
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            
            lstProdutos.Add(produto);

            dtgVenda.Rows.Clear();
            dtgVenda.Refresh();

            dtgVenda.DataSource = lstProdutos;

            dtgVenda.Refresh();
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

            dt.Columns.Add("Nome");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Valor");

            foreach(DataGridViewRow item in dtgVenda.Rows)
            {
                dt.Rows.Add(item.Cells["Nome"].Value.ToString(), item.Cells["Quantidade"].Value.ToString(), Convert.ToDecimal(item.Cells["Valor"].Value.ToString()));
            }

            return dt;
        }
    }
}
