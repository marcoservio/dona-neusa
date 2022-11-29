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
            return _dao.ListarTodos();
        }

        public Produto BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public List<Produto> ListarPor(string nome)
        {
            return _dao.ListarPor(nome);
        }

        public List<Produto> ListarTodosAtivos()
        {
            return _dao.ListarTodos().Where(p => p.Inativo != SimNao.S).ToList();
        }

        public void Incluir(Produto produto)
        {
            _dao.Incluir(produto);
        }

        public void Alterar(Produto produto)
        {
            _dao.Alterar(produto);
        }

        public void Excluir(Produto produto)
        {
            _dao.Excluir(produto);
        }
    }
}
