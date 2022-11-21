using PastelECia.Views;
using PastelECia.Models;

using System;

namespace PastelECia
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            new VersaoSistema(1, 1, 9);

            frmVenda frm = new frmVenda();
            frm.ShowDialog();
        }
    }
}
