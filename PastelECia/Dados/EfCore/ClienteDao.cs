using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class ClienteDao : ICommand<Cliente>, IQuery<Cliente>
    {
        public List<Cliente> ListarTodos()
        {
            using(var dbContext = new DataContext())
            {
                var lstClientes = (from cliente in dbContext.Cliente select cliente).ToList();

                if(lstClientes != null && lstClientes.Count > 0)
                    return lstClientes;

                return null;
            }
        }

        public Cliente ListarPor(int id)
        {
            using(var dbContext = new DataContext())
            {
                var cliente = dbContext.Cliente.Find(id);

                if(cliente != null)
                    return cliente;

                return null;
            }
        }

        public List<Cliente> ListarPor(string nome)
        {
            using(var dbContext = new DataContext())
            {
                var lstClientes = dbContext.Cliente.Where(c => c.Nome == nome).ToList();

                if(lstClientes != null && lstClientes.Count > 0)
                {
                    return lstClientes;
                }

                return null;
            }
        }

        public void Incluir(Cliente cliente)
        {
            using(var dbContext = new DataContext())
            {
                if(cliente.Id == 0)
                    dbContext.Cliente.Add(cliente);

                dbContext.SaveChanges();
            }
        }

        public void Alterar(Cliente cliente)
        {
            using(var dbContext = new DataContext())
            {
                if(cliente.Id != 0)
                    dbContext.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public void Excluir(Cliente cliente)
        {
            using(var dbContext = new DataContext())
            {
                var entry = dbContext.Entry(cliente);

                if(entry.State == System.Data.Entity.EntityState.Detached)
                    dbContext.Cliente.Attach(cliente);

                dbContext.Cliente.Remove(cliente);
                dbContext.SaveChanges();
            }
        }
    }
}