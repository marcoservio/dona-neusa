using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Services
{
    public class VersaoSistemaService : ICommand<VersaoSistema>, IQuery<VersaoSistema>
    {
        private readonly VersaoSistemaDao _dao = new VersaoSistemaDao();

        public void Alterar(VersaoSistema obj)
        {
            _dao.Alterar(obj);
        }

        public VersaoSistema BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public void Excluir(VersaoSistema obj)
        {
            _dao.Excluir(obj);
        }

        public void Incluir(VersaoSistema obj)
        {
            _dao.Incluir(obj);
        }

        public List<VersaoSistema> ListarTodos()
        {
            return _dao.ListarTodos();
        }

        public VersaoSistema BuscarUltimaVersao()
        {
            return _dao.ListarTodos().OrderByDescending(s => s.Id).First();
        }
    }
}
