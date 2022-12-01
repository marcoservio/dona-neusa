using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;

namespace PastelECia.Services
{
    public class ParametroService : ICommand<Parametro>, IQuery<Parametro>
    {
        private readonly ParametroDao _dao = new ParametroDao();

        public void Alterar(Parametro obj)
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

        public Parametro BuscarPor(int id)
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

        public void Excluir(Parametro obj)
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

        public void Incluir(Parametro obj)
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

        public List<Parametro> ListarTodos()
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
