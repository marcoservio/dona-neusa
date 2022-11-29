using static PastelECia.Models.Enum.Enumerador;
using System;

namespace PastelECia.Models
{
    public class VersaoSistema : IModelo
    {
        public VersaoSistema()
        {
            VersaoSis = 0;
            VersaoBanco = 0;
            Revisao = 0;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public int VersaoSis { get; set; }
        public int VersaoBanco { get; set; }
        public int Revisao { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
