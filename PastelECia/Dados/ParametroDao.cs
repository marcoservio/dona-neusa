using PastelECia.Dados.Context;
using PastelECia.Models;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class ParametroDao : ICommand<Parametro>, IQuery<Parametro>
    {
        public List<Parametro> ListarTodos()
        {
            using (var _context = new AppDbContext())
            {
                return _context.Parametro.ToList();
            }
        }

        public Parametro BuscarPor(int id)
        {
            using (var _context = new AppDbContext())
            {
                var parametro = _context.Parametro.Find(id);

                if (parametro == null)
                    return null;

                return parametro;
            }
        }

        public void Incluir(Parametro parametro)
        {
            using (var _context = new AppDbContext())
            {
                _context.Parametro.Add(parametro);
                _context.SaveChanges();
            }
        }

        public void Alterar(Parametro parametro)
        {
            using (var _context = new AppDbContext())
            {
                _context.Entry(parametro).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(Parametro parametro)
        {
            using (var _context = new AppDbContext())
            {
                var entry = _context.Entry(parametro);

                if (entry.State == EntityState.Detached)
                    _context.Parametro.Attach(parametro);

                _context.Parametro.Remove(parametro);
                _context.SaveChanges();
            }
        }
    }
}
