using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models
{
    public class VersaoSistema
    {
        public VersaoSistema(int versaoSis, int versaoBanco, int build, int revisao)
        {
            VersaoSis = versaoSis;
            VersaoBanco = versaoBanco;
            Build = build;
            Revisao = revisao;
        }

        public int VersaoSis { get; set; }
        public int VersaoBanco { get; set; }
        public int Build { get; set; }
        public int Revisao { get; set; }
    }
}
