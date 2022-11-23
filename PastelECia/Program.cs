using PastelECia.Models;
using PastelECia.Views;

using System;
using System.IO;
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

                new VersaoSistema(1, 1, 15);

                VersaoAvaliacao(true);

                using(frmTesteBanco frm = new frmTesteBanco())
                    frm.ShowDialog();

                //using(frmVenda frm = new frmVenda())
                //    frm.ShowDialog();
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
                var parametros = new Parametro();
                var data = DateTime.MinValue;

                if(!File.Exists("config.txt"))
                    CriaArquivo("config.txt");

                parametros = LeArquivo("config.txt");

                data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, parametros.DiaLimiteAcesso, 23, 59, 59);

                if(DateTime.Now > data)
                    throw new Exception("Tempo de teste da aplicação acabou! Contacte algum desenvolvedor do sistema para mais informações.");
            }
        }

        private static Parametro LeArquivo(string caminho)
        {
            Parametro par = new Parametro();

            using(var fs = new FileStream(caminho, FileMode.Open))
            using(var leitor = new BinaryReader(fs))
            {
                var nome = leitor.ReadString();
                par.DiaLimiteAcesso = leitor.ReadInt32();
            }

            return par;
        }

        private static void CriaArquivo(string caminho)
        {
            int dataLimite = DateTime.Now.Day + 5;

            using(var fs = new FileStream(caminho, FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write($"diaLimiteAcesso:");
                escritor.Write(dataLimite);
            }
        }
    }
}
