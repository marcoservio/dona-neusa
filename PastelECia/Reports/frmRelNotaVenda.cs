using System;
using System.Data;
using System.Windows.Forms;

namespace PastelECia.Relatorios
{
    public partial class frmRelNotaVenda : Form
    {
        private DataTable dt = new DataTable();

        public frmRelNotaVenda(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmRelNotaVenda_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
