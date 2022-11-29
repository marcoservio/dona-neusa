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
            _dao.Alterar(obj);
        }

        public Endereco BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public void Excluir(Endereco obj)
        {
            _dao.Excluir(obj);
        }

        public void Incluir(Endereco obj)
        {
            _dao.Incluir(obj);
        }

        public List<Endereco> ListarTodos()
        {
            return _dao.ListarTodos();
        }
    }
}
