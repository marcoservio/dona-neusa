using PastelECia.Models;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class EnderecoDao : ICommand<Endereco>, IQuery<Endereco>
    {
        public List<Endereco> ListarTodos()
        {
            using(var _context = new AppDbContext())
            {
                return _context.Endereco.ToList();
            }
        }

        public Endereco BuscarPor(int id)
        {
            using(var _context = new AppDbContext())
            {
                return _context.Endereco.Find(id);
            }
        }

        public void Incluir(Endereco endereco)
        {
            using(var _context = new AppDbContext())
            {
                _context.Endereco.Add(endereco);
                _context.SaveChanges();
            }
        }

        public void Alterar(Endereco endereco)
        {
            using(var _context = new AppDbContext())
            {
                _context.Entry(endereco).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(Endereco endereco)
        {
            using(var _context = new AppDbContext())
            {
                var entry = _context.Entry(endereco);

                if(entry.State == EntityState.Detached)
                    _context.Endereco.Attach(endereco);

                _context.Endereco.Remove(endereco);
                _context.SaveChanges();
            }
        }
    }
}
