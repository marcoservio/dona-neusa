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
            using(var dbContext = new AppDbContext())
            {
                return dbContext.Cliente.Include(c => c.Endereco).ToList();
            }
        }

        public Cliente BuscarPor(int id)
        {
            using(var dbContext = new AppDbContext())
            {
                return dbContext.Cliente.Find(id);
            }
        }

        public List<Cliente> ListarPor(string nome)
        {
            using(var dbContext = new AppDbContext())
            {
                return dbContext.Cliente.Where(c => c.Nome.Contains(nome)).ToList();
            }
        }

        public void Incluir(Cliente cliente)
        {
            using(var dbContext = new AppDbContext())
            {
                dbContext.Cliente.Add(cliente);
                dbContext.SaveChanges();
            }
        }

        public void Alterar(Cliente cliente)
        {
            using(var dbContext = new AppDbContext())
            {
                dbContext.Entry(cliente).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Excluir(Cliente cliente)
        {
            using(var dbContext = new AppDbContext())
            {
                var entry = dbContext.Entry(cliente);

                if(entry.State == EntityState.Detached)
                    dbContext.Cliente.Attach(cliente);

                dbContext.Cliente.Remove(cliente);
                dbContext.SaveChanges();
            }
        }
    }
}