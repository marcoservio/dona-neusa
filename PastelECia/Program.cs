using PastelECia.Dados.EfCore.Utilitarios;
using PastelECia.Security;
using PastelECia.Views;

using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PastelECia
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                new ComBancoDados(true);
                new VersaoAvaliacao(false);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
