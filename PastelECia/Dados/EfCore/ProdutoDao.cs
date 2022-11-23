using PastelECia.Models;

using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class ProdutoDao : ICommand<Produto>, IQuery<Produto>
    {
        public List<Produto> ListarTodos()
        {
            using(var dbContext = new DataContext())
            {
                var lstProduto = (from produto in dbContext.Produto select produto).ToList();

                if(lstProduto != null && lstProduto.Count > 0)
                    return lstProduto;

                return null;
            }
        }

        public Produto ListarPor(int id)
        {
            using(var dbContext = new DataContext())
            {
                var produto = dbContext.Produto.Find(id);

                if(produto != null)
                    return produto;

                return null;
            }
        }

        public List<Produto> ListarPor(string nome)
        {
            using(var dbContext = new DataContext())
            {
                var lstProdutos = dbContext.Produto.Where(p => p.Nome_prd == nome).ToList();

                if(lstProdutos != null && lstProdutos.Count > 0)
                {
                    return lstProdutos;
                }

                return null;
            }
        }

        public void Incluir(Produto produto)
        {
            using(var dbContext = new DataContext())
            {
                if(produto.Id == 0)
                    dbContext.Produto.Add(produto);

                dbContext.SaveChanges();
            }
        }

        public void Alterar(Produto produto)
        {
            using(var dbContext = new DataContext())
            {
                if(produto.Id != 0)
                    dbContext.Entry(produto).State = System.Data.Entity.EntityState.Modified;

                dbContext.SaveChanges();
            }
        }

        public void Excluir(Produto produto)
        {
            using(var dbContext = new DataContext())
            {
                var entry = dbContext.Entry(produto);

                if(entry.State == System.Data.Entity.EntityState.Detached)
                    dbContext.Produto.Attach(produto);

                dbContext.Produto.Remove(produto);
                dbContext.SaveChanges();
            }
        }
    }
}
