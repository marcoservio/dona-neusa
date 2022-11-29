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
            _dao.Alterar(obj);
        }

        public Cliente BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public void Excluir(Cliente obj)
        {
            _dao.Excluir(obj);
        }

        public void Incluir(Cliente obj)
        {
            _dao.Incluir(obj);
        }

        public List<Cliente> ListarTodos()
        {
            return _dao.ListarTodos();
        }
    }
}
