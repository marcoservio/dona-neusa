using PastelECia.Services;

using System;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmSobre : Form
    {
        private readonly VersaoSistemaService _service = new VersaoSistemaService();

        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var versao = _service.BuscarUltimaVersao();

                if (versao != null)
                    lblVersao.Text = $"Versão {versao.VersaoSis}.{versao.VersaoBanco}.{versao.Revisao}";

                lblData.Text = new DateTime(2022, 11, 1).ToString("D");
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
