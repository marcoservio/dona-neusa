using System;

using static PastelECia.Models.Enum.Enumerador;

namespace PastelECia.Models
{
    public class Parametro : IModelo
    {
        public Parametro()
        {
            DataLimiteAcesso = DateTime.MaxValue;
            CodigoAtivacao = string.Empty;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DataLimiteAcesso { get; set; }
        public string CodigoAtivacao { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
