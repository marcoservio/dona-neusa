using PastelECia.Models;

using System;
using System.IO;

namespace PastelECia.Security
{
    public class VersaoAvaliacao
    {
        private const string CHAVE = "@@D0NA_NEUS4";

        public void Ativar(bool ehAvaliacao)
        {
            if (ehAvaliacao)
            {
                var parametros = new Parametro();

                if (!File.Exists("config.txt"))
                    CriaArquivo("config.txt");

                parametros = LeArquivo("config.txt");

                if (DateTime.Now > parametros.DataLimiteAcesso)
                    throw new Exception("Tempo de teste da aplicação acabou! Contacte algum desenvolvedor do sistema para mais informações.");
            }
        }

        private Parametro LeArquivo(string caminho)
        {
            Parametro par = new Parametro();
            string diaLimiteAcesso = string.Empty;

            using (var fs = new FileStream(caminho, FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                diaLimiteAcesso = leitor.ReadString();
            }

            diaLimiteAcesso = new Criptografia().Descriptografar(diaLimiteAcesso, CHAVE);
            par.DataLimiteAcesso = Convert.ToDateTime(diaLimiteAcesso.Split(':')[1]);

            return par;
        }

        private void CriaArquivo(string caminho)
        {
            DateTime dataLimite = DateTime.Now.AddDays(5);
            string mensagem = $"diaLimiteAcesso: {dataLimite.ToString("d")}";
            string mensagemCriptografada = new Criptografia().Criptografar(mensagem, CHAVE);

            using (var fs = new FileStream(caminho, FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(mensagemCriptografada);
            }
        }
    }
}
