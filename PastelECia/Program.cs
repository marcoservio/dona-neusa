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

                new VersaoSistema(1, 1, 15);

                //frmAtivador ativador = new frmAtivador();
                //ativador.ShowDialog();

                //if(!ativador.ProdutoAtivado)

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
                var parametros = new Parametros();
                var data = DateTime.MinValue;

                if(!File.Exists("config.txt"))
                    CriaArquivo("config.txt");

                parametros = LeArquivo("config.txt");

                data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, parametros.DiaLimiteAcesso, 23, 59, 59);

                if(DateTime.Now > data)
                    throw new Exception("Tempo de teste da aplicação acabou! Contacte algum desenvolvedor do sistema para mais informações.");
            }
        }

        private static Parametros LeArquivo(string caminho)
        {
            Parametros par = new Parametros();

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
