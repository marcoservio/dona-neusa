namespace PastelECia.Models
{
    public class VersaoSistema
    {
        public VersaoSistema(int versaoSis, int versaoBanco, int revisao)
        {
            Id = 0;
            VersaoSis = versaoSis;
            VersaoBanco = versaoBanco;
            Revisao = revisao;
        }

        public int Id { get; set; }
        public int VersaoSis { get; set; }
        public int VersaoBanco { get; set; }
        public int Revisao { get; set; }
    }
}
