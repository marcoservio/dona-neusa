using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;

namespace PastelECia.Services
{
    public class ClienteService : ICommand<Cliente>, IQuery<Cliente>
    {
        private readonly ClienteDao _dao = new ClienteDao();

        public void Alterar(Cliente obj)
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

        public Cliente BuscarPor(int id)
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

        public void Excluir(Cliente obj)
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

        public void Incluir(Cliente obj)
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

        public List<Cliente> ListarTodos()
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
