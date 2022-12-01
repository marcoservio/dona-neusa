using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

using static PastelECia.Models.Enum.Enumerador;

namespace PastelECia.Services
{
    public class ProdutoService : ICommand<Produto>, IQuery<Produto>
    {
        private readonly ProdutoDao _dao = new ProdutoDao();

        public List<Produto> ListarTodos()
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

        public Produto BuscarPor(int id)
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

        public List<Produto> ListarPor(string nome)
        {
            try
            {
                return _dao.ListarPor(nome);
            }
            catch
            {
                throw;
            }
        }

        public List<Produto> ListarTodosAtivos()
        {
            try
            {
                return _dao.ListarTodos().Where(p => p.Inativo != SimNao.S).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Incluir(Produto produto)
        {
            try
            {
                _dao.Incluir(produto);
            }
            catch
            {
                throw;
            }
        }

        public void Alterar(Produto produto)
        {
            try
            {
                _dao.Alterar(produto);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Produto produto)
        {
            try
            {
                _dao.Excluir(produto);
            }
            catch
            {
                throw;
            }
        }
    }
}
