using PastelECia.Models;
using PastelECia.Security;
using PastelECia.Services;
using PastelECia.Views;

using System;
using System.IO;
using System.Text;
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
                Cursor.Current = Cursors.WaitCursor;

                new ControleVersaoSistema(1, 1, 16);
                new VersaoAvaliacao().Ativar(false);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
