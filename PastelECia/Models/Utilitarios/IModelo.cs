using static PastelECia.Models.Enum.Enumerador;
using System;

namespace PastelECia.Models
{
    public interface IModelo
    {
        int Id { get; set; }
        SimNao Inativo { get; set; }
        DateTime DataAlteracao { get; set; }
    }
}
