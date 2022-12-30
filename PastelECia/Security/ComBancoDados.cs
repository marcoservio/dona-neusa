using PastelECia.Dados.EfCore.Utilitarios;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Security
{
    public class ComBancoDados
    {
        public ComBancoDados(bool comBanco)
        {
            if (comBanco)
            {
                try
                {
                    ConnectionTest.Test();
                    new ControleVersaoSistema(1, 1, 20);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
