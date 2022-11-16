using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.VO
{
    public class Venda
    {
        public List<Produto> lstProduto { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
