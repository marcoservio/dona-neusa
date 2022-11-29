using PastelECia.Dados;
using PastelECia.Dados.EfCore;
using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Services
{
    public class UnidadeMedidaService : ICommand<UnidadeMedida>, IQuery<UnidadeMedida>
    {
        private readonly UnidadeMedidaDao _dao = new UnidadeMedidaDao();

        public void Alterar(UnidadeMedida obj)
        {
            _dao.Alterar(obj);
        }

        public UnidadeMedida BuscarPor(int id)
        {
            return _dao.BuscarPor(id);
        }

        public void Excluir(UnidadeMedida obj)
        {
            _dao.Excluir(obj);
        }

        public void Incluir(UnidadeMedida obj)
        {
            _dao.Incluir(obj);
        }

        public List<UnidadeMedida> ListarTodos()
        {
            return _dao.ListarTodos();
        }
    }
}
