using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Dados.EfCore
{
    public class ParametroDao : ICommand<Parametro>, IQuery<Parametro>
    {
        public List<Parametro> ListarTodos()
        {
            using(var dbContext = new DataContext())
            {
                var lstParametros = (from parametro in dbContext.Parametro select parametro).ToList();

                if(lstParametros != null && lstParametros.Count > 0)
                    return lstParametros;

                return null;
            }
        }

        public Parametro ListarPor(int id)
        {
            using(var dbContext = new DataContext())
            {
                var parametro = dbContext.Parametro.Find(id);

                if(parametro != null)
                    return parametro;

                return null;
            }
        }

        public void Incluir(Parametro parametro)
        {
            using(var dbContext = new DataContext())
            {
                if(parametro.Id == 0)
                    dbContext.Parametro.Add(parametro);

                dbContext.SaveChanges();
            }
        }

        public void Alterar(Parametro parametro)
        {
            using(var dbContext = new DataContext())
            {
                if(parametro.Id != 0)
                    dbContext.Entry(parametro).State = System.Data.Entity.EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public void Excluir(Parametro parametro)
        {
            using(var dbContext = new DataContext())
            {
                var entry = dbContext.Entry(parametro);

                if(entry.State == System.Data.Entity.EntityState.Detached)
                    dbContext.Parametro.Attach(parametro);

                dbContext.Parametro.Remove(parametro);
                dbContext.SaveChanges();
            }
        }
    }
}
