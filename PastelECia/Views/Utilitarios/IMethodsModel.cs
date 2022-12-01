using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public interface IMethodsModel<T>
    {
        void DesenharGrid();
        void CarregarGrid(List<T> lst);
        T TelaParaObjeto();
        void ObjetoParaTela(T obj);
        void LimparTela();
        void LimparGrid();
        void UpdateRefreshGrid();
        void TxtSomenteNumeroKeyPress(object sender, KeyPressEventArgs e);
        void TxtDecimalKeyPress(object sender, KeyPressEventArgs e, TextBox txt);
        void TxtDecimalLeave(object sender, EventArgs e, TextBox txt);
    }
}
