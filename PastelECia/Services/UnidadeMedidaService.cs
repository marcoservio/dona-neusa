using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;

namespace PastelECia.Services
{
    public class UnidadeMedidaService : ICommand<UnidadeMedida>, IQuery<UnidadeMedida>
    {
        private readonly UnidadeMedidaDao _dao = new UnidadeMedidaDao();

        public void Alterar(UnidadeMedida obj)
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

        public UnidadeMedida BuscarPor(int id)
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

        public void Excluir(UnidadeMedida obj)
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

        public void Incluir(UnidadeMedida obj)
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

        public List<UnidadeMedida> ListarTodos()
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
    }
}
