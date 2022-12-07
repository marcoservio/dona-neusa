using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class UnidadeMedidaDao : ICommand<UnidadeMedida>, IQuery<UnidadeMedida>
    {
        public List<UnidadeMedida> ListarTodos()
        {
            using(var _context = new AppDbContext())
            {
                return _context.UnidadeMedida.ToList();
            }
        }

        public UnidadeMedida BuscarPor(int id)
        {
            using(var _context = new AppDbContext())
            {
                var unidade = _context.UnidadeMedida.Find(id);

                if (unidade == null)
                    throw new Exception($"A unidade de medida com o código {id} não existe.");

                return unidade;
            }
        }

        public List<UnidadeMedida> ListarPor(string nome)
        {
            using(var _context = new AppDbContext())
            {
                return _context.UnidadeMedida.Where(p => p.Nome.Contains(nome)).ToList();
            }
        }

        public void Incluir(UnidadeMedida obj)
        {
            using(var _context = new AppDbContext())
            {
                _context.UnidadeMedida.Add(obj);
                _context.SaveChanges();
            }
        }

        public void Alterar(UnidadeMedida obj)
        {
            using(var _context = new AppDbContext())
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(UnidadeMedida obj)
        {
            using(var _context = new AppDbContext())
            {
                var entry = _context.Entry(obj);

                if(entry.State == EntityState.Detached)
                    _context.UnidadeMedida.Attach(obj);

                _context.UnidadeMedida.Remove(obj);
                _context.SaveChanges();
            }
        }
    }
}
