using PastelECia.Views;
using PastelECia.Models;

using System;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.IO;
using System.Net.Http.Headers;

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

                new VersaoSistema(1, 1, 14);

                VersaoAvaliacao(true);

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

        private static void VersaoAvaliacao(bool ehAvaliacao)
        {
            if(ehAvaliacao)
            {
                var line = LeArquivo();

                if(line.Contains("diaLimiteAcesso:"))
                    line = line.Replace("diaLimiteAcesso:", "").Trim();

                var data = DateTime.MinValue;
                if(int.TryParse(line.Trim(), out int diaLimiteAcesso))
                    data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, diaLimiteAcesso, 23, 59, 59);

                if(DateTime.Now > data)
                    throw new Exception("Tempo de teste da aplicação acabou! Contacte algum desenvolvedor do sistema para mais informações.");
            }
        }

        private static string LeArquivo()
        {
            string line = string.Empty;

            using(var fluxoArquivo = new FileStream("config.txt", FileMode.Open))
            using(var leitor = new StreamReader(fluxoArquivo))
            {
                while(!leitor.EndOfStream)
                {
                    line += leitor.ReadLine();
                }
            }

            return line;
        }
    }
}
