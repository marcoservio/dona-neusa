using PastelECia.Models;
using PastelECia.Services;
using PastelECia.Views;

using System;
using System.IO;
using System.Windows.Forms;

namespace PastelECia
{
    public static class Program
    {
        private static VersaoSistemaService _service = new VersaoSistemaService();

        [STAThread]
        static void Main()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                
                //ControleVersaoSistema();

                VersaoAvaliacao(true);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());
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

        private static void ControleVersaoSistema()
        {
            VersaoSistema versao = new VersaoSistema();
            versao.VersaoSis = 1;
            versao.VersaoBanco = 1;
            versao.Revisao = 16;

            var tmp = _service.BuscarUltimaVersao();

            if(tmp != null || tmp.VersaoSis != versao.VersaoSis || tmp.VersaoBanco != versao.VersaoBanco || tmp.Revisao != versao.Revisao)
                _service.Incluir(versao);
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

                data = parametros.DataLimiteAcesso;

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
                par.DataLimiteAcesso = Convert.ToDateTime(leitor.ReadString());
            }

            return par;
        }

        private static void CriaArquivo(string caminho)
        {
            DateTime dataLimite = DateTime.Now.AddDays(5);

            using(var fs = new FileStream(caminho, FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write($"diaLimiteAcesso:");
                escritor.Write(dataLimite.ToString());
            }
        }
    }
}
