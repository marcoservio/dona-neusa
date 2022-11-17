using PastelECia.Cliente;

using System;

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
