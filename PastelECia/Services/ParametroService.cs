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
            _dao.Alterar(obj);
        }

        public Parametro BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public void Excluir(Parametro obj)
        {
            _dao.Excluir(obj);
        }

        public void Incluir(Parametro obj)
        {
            _dao.Incluir(obj);
        }

        public List<Parametro> ListarTodos()
        {
            return _dao.ListarTodos();
        }
    }
}
