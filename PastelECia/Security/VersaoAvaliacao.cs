using PastelECia.Models;

using System;
using System.IO;

namespace PastelECia.Security
{
    public class VersaoAvaliacao
    {
        public VersaoAvaliacao(bool ehAvaliacao)
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
            var diaLimiteAcessoCriptografado = Arquivo.Read(caminho);

            diaLimiteAcesso = Criptografia.Descriptografar(diaLimiteAcessoCriptografado, ChaveCriptografia.CHAVE);
            par.DataLimiteAcesso = Convert.ToDateTime(diaLimiteAcesso.Split(':')[1]);

            return par;
        }

        private void CriaArquivo(string caminho)
        {
            DateTime dataLimite = DateTime.Now.AddDays(5);
            string mensagem = $"diaLimiteAcesso: {dataLimite.ToString("d")}";
            string mensagemCriptografada = Criptografia.Criptografar(mensagem, ChaveCriptografia.CHAVE);
            Arquivo.Write(caminho, mensagemCriptografada);
        }
    }
}
