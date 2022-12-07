using PastelECia.Models;
using PastelECia.Services;

namespace PastelECia.Security
{
    public class ControleVersaoSistema
    {
        private static VersaoSistemaService _service = new VersaoSistemaService();

        public ControleVersaoSistema(int versaoSistema, int versaoBanco, int revisao)
        {
            VersaoSistema versao = new VersaoSistema();
            versao.VersaoSis = versaoSistema;
            versao.VersaoBanco = versaoBanco;
            versao.Revisao = revisao;

            var tmp = _service.BuscarUltimaVersao();

            if (tmp != null)
            {
                if (tmp.VersaoSis != versao.VersaoSis || tmp.VersaoBanco != versao.VersaoBanco || tmp.Revisao != versao.Revisao)
                    _service.Incluir(versao);
            }
            else
                _service.Incluir(versao);
        }
    }
}
