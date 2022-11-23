using Microsoft.Reporting.Map.WebForms.BingMaps;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmAtivador : Form
    {
        public bool ProdutoAtivado { get; set; }

        public frmAtivador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if(mktxtChave.Text.ToUpper() == "NPPR9-FWDCX-D2C8J-H872K-2YT43")
            {
                MessageBox.Show("Produto ativado com sucesso!", "Ativação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ProdutoAtivado = true;
                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("Produto não foi ativado!", "Ativação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ProdutoAtivado = false;
            }
        }
    }
}
