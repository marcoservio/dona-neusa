using System;
using System.Data;
using System.Windows.Forms;

namespace PastelECia.Relatorios
{
    public partial class frmRelNotaVenda : Form
    {
        private DataTable dtProduto = new DataTable();
        private string nomeCliente = string.Empty;

        public frmRelNotaVenda(DataTable dtProduto, string nomeCliente)
        {
            InitializeComponent();
            this.dtProduto = dtProduto;
            this.nomeCliente = nomeCliente;
        }

        private void frmRelNotaVenda_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nomeCliente))
                nomeCliente = " ";

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dtProduto));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeCliente", nomeCliente));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
