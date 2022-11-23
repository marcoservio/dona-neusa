using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class VersaoSistemaDao : ICommand<VersaoSistema>, IQuery<VersaoSistema>
    {
        public List<VersaoSistema> ListarTodos()
        {
            using(var dbContext = new DataContext())
            {
                var lstVersoes = (from versao in dbContext.VersaoSistema select versao).ToList();

                if(lstVersoes != null && lstVersoes.Count > 0)
                    return lstVersoes;

                return null;
            }
        }

        public VersaoSistema ListarPor(int id)
        {
            using(var dbContext = new DataContext())
            {
                var versao = dbContext.VersaoSistema.Find(id);

                if(versao != null)
                    return versao;

                return null;
            }
        }

        public void Incluir(VersaoSistema versao)
        {
            using(var dbContext = new DataContext())
            {
                if(versao.Id == 0)
                    dbContext.VersaoSistema.Add(versao);

                dbContext.SaveChanges();
            }
        }

        public void Alterar(VersaoSistema versao)
        {
            using(var dbContext = new DataContext())
            {
                if(versao.Id != 0)
                    dbContext.Entry(versao).State = System.Data.Entity.EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public void Excluir(VersaoSistema versao)
        {
            using(var dbContext = new DataContext())
            {
                var entry = dbContext.Entry(versao);

                if(entry.State == System.Data.Entity.EntityState.Detached)
                    dbContext.VersaoSistema.Attach(versao);

                dbContext.VersaoSistema.Remove(versao);
                dbContext.SaveChanges();
            }
        }
    }
}
