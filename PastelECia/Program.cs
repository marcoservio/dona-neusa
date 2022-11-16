using PastelECia.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            frmVenda frm = new frmVenda();
            frm.ShowDialog();
        }
    }
}
