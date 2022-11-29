using System.Collections.Generic;

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
    }
}
