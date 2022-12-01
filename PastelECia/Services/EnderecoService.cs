using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;

namespace PastelECia.Services
{
    public class EnderecoService : ICommand<Endereco>, IQuery<Endereco>
    {
        private readonly EnderecoDao _dao = new EnderecoDao();

        public void Alterar(Endereco obj)
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

        public Endereco BuscarPor(int id)
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

        public void Excluir(Endereco obj)
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

        public void Incluir(Endereco obj)
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

        public List<Endereco> ListarTodos()
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
