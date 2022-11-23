using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models
{
    public class Parametro
    {
        public Parametro()
        {
            Id = 0;
            DiaLimiteAcesso = 0;
            CodigoAtivacao = string.Empty;
        }

        public int Id { get; set; }
        public int DiaLimiteAcesso { get; set; }
        public string CodigoAtivacao { get; set; }
    }
}
