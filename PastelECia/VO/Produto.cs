using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.VO
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Quantidade * Valor;
            }
        }

        public Produto()
        {
            Nome = string.Empty;
            Valor = decimal.Zero;
            Quantidade = decimal.Zero;
        }
    }
}
