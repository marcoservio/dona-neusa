using PastelECia.Views;
using PastelECia.Models;

using System;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.IO;

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

                new VersaoSistema(1, 1, 13);

                var line = string.Empty;

                using(StreamReader sr = new StreamReader("config.txt"))
                {
                    line = sr.ReadToEnd();
                }

                if(line.Contains("diaLimiteAcesso:"))
                    line = line.Replace("diaLimiteAcesso:", "").Trim();

                var data = DateTime.MinValue;
                if(int.TryParse(line.Trim(), out int diaLimiteAcesso))
                   data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, diaLimiteAcesso, 23, 59, 59);

                if(DateTime.Now >  data)
                    throw new Exception("Tempo de teste da aplicação acabou! Contacte algum desenvolvedor do sistema para mais informações.");

                frmVenda frm = new frmVenda();
                frm.ShowDialog();
            }
            catch(Exception ex)
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
