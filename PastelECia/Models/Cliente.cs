using static PastelECia.Models.Enum.Enumerador;
using System;

namespace PastelECia.Models
{
    public class Cliente : IModelo
    {
        public Cliente()
        {
            Nome = string.Empty;
            CnpjCpf = string.Empty;
            Telefone = string.Empty;
            Email = string.Empty;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public virtual Endereco Endereco { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
