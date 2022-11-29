using static PastelECia.Models.Enum.Enumerador;
using System;

namespace PastelECia.Models
{
    public class Endereco : IModelo
    {
        public Endereco()
        {
            Locradouro = string.Empty;
            Numero = 0;
            Complemento = string.Empty;
            Bairro = string.Empty;
            Cidade = string.Empty;
            Pais = string.Empty;
            Estado = string.Empty;
            Cep = string.Empty;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Locradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
