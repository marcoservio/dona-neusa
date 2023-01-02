using PastelECia.Dados.Context;
using PastelECia.Models;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class ClienteDao : ICommand<Cliente>, IQuery<Cliente>
    {
        public List<Cliente> ListarTodos()
        {
            using (var _context = new AppDbContext())
            {
                return _context.Cliente.Include(c => c.Endereco).ToList();
            }
        }

        public Cliente BuscarPor(int id)
        {
            using (var _context = new AppDbContext())
            {
                var lstClientes = _context.Cliente.Include(c => c.Endereco).Where(c => c.Id == id).ToList();

                if (lstClientes == null || lstClientes.Count == 0)
                    return null;

                return lstClientes.First();
            }
        }

        public List<Cliente> ListarPor(string nome)
        {
            using (var _context = new AppDbContext())
            {
                return _context.Cliente.Include(c => c.Endereco).Where(c => c.Nome.Contains(nome)).ToList();
            }
        }

        public void Incluir(Cliente cliente)
        {
            using (var _context = new AppDbContext())
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
            }
        }

        public void Alterar(Cliente cliente)
        {
            using (var _context = new AppDbContext())
            {
                _context.Entry(cliente).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(Cliente cliente)
        {
            using (var _context = new AppDbContext())
            {
                var entry = _context.Entry(cliente);

                if (entry.State == EntityState.Detached)
                    _context.Cliente.Attach(cliente);

                _context.Cliente.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}