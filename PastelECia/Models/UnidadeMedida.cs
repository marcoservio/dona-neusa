using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using static PastelECia.Models.Enum.Enumerador;

namespace PastelECia.Models
{
    public class UnidadeMedida : IModelo
    {
        public UnidadeMedida()
        {
            Nome = string.Empty;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }
        [NotMapped]
        public string NomeDescricao
        {
            get
            {
                return $"{Nome} - {Descricao}";
            }
        }

        public override string ToString()
        {
            return $"{Nome} - {Descricao}";
        }
    }
}
