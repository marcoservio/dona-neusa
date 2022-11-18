using PastelECia.Cliente;
using PastelECia.Models;

using System;

namespace PastelECia
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            new VersaoSistema(1, 1, 8);

            frmVenda frm = new frmVenda();
            frm.ShowDialog();
        }
    }
}
