using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class EnderecoDao : ICommand<Endereco>, IQuery<Endereco>
    {
        public List<Endereco> ListarTodos()
        {
            using(var dbContext = new DataContext())
            {
                var lstEnderecos = (from endereco in dbContext.Endereco select endereco).ToList();

                if(lstEnderecos != null && lstEnderecos.Count > 0)
                    return lstEnderecos;

                return null;
            }
        }

        public Endereco ListarPor(int id)
        {
            using(var dbContext = new DataContext())
            {
                var endereco = dbContext.Endereco.Find(id);

                if(endereco != null)
                    return endereco;

                return null;
            }
        }

        public void Incluir(Endereco endereco)
        {
            using(var dbContext = new DataContext())
            {
                if(endereco.Id == 0)
                    dbContext.Endereco.Add(endereco);

                dbContext.SaveChanges();
            }
        }

        public void Alterar(Endereco endereco)
        {
            using(var dbContext = new DataContext())
            {
                if(endereco.Id != 0)
                    dbContext.Entry(endereco).State = System.Data.Entity.EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public void Excluir(Endereco endereco)
        {
            using(var dbContext = new DataContext())
            {
                var entry = dbContext.Entry(endereco);

                if(entry.State == System.Data.Entity.EntityState.Detached)
                    dbContext.Endereco.Attach(endereco);

                dbContext.Endereco.Remove(endereco);
                dbContext.SaveChanges();
            }
        }
    }
}
