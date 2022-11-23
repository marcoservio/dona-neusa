using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmTesteBanco : Form
    {
        public frmTesteBanco()
        {
            InitializeComponent();
        }

        private void frmTesteBanco_Load(object sender, EventArgs e)
        {
            List<Produto> lstProdutos = new ProdutoDao().ListarTodos();
            dtgTeste.DataSource = lstProdutos;
        }
    }
}
