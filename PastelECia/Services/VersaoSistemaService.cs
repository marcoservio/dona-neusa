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
            try
            {
                _dao.Alterar(obj);
            }
            catch
            {
                throw;
            }
        }

        public VersaoSistema BuscarPor(int id)
        {
            try
            {
                return _dao.BuscarPor(id);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(VersaoSistema obj)
        {
            try
            {
                _dao.Excluir(obj);
            }
            catch
            {
                throw;
            }
        }

        public void Incluir(VersaoSistema obj)
        {
            try
            {
                _dao.Incluir(obj);
            }
            catch
            {
                throw;
            }
        }

        public List<VersaoSistema> ListarTodos()
        {
            try
            {
                return _dao.ListarTodos();
            }
            catch
            {
                throw;
            }
        }

        public VersaoSistema BuscarUltimaVersao()
        {
            try
            {
                var lstVersao = _dao.ListarTodos();

                if (lstVersao == null || lstVersao.Count == 0)
                    return null;

                return lstVersao.OrderByDescending(s => s.Id).First();
            }
            catch
            {
                throw;
            }
        }
    }
}
