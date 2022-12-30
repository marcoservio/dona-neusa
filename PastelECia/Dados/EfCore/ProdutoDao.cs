using PastelECia.Models;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class ProdutoDao : ICommand<Produto>, IQuery<Produto>
    {
        public List<Produto> ListarTodos()
        {
            using (var _context = new AppDbContext())
            {
                return _context.Produto.Include(p => p.UnidadeMedida).ToList();
            }
        }

        public Produto BuscarPor(int id)
        {
            using (var _context = new AppDbContext())
            {
                var lstProdutos = _context.Produto.Include(p => p.UnidadeMedida).Where(p => p.Id == id).ToList();

                if (lstProdutos == null || lstProdutos.Count == 0)
                    return null;

                return lstProdutos.First();
            }
        }

        public List<Produto> ListarPor(string nome)
        {
            using (var _context = new AppDbContext())
            {
                return _context.Produto.Include(p => p.UnidadeMedida).Where(p => p.Nome.Contains(nome)).ToList();
            }
        }

        public void Incluir(Produto produto)
        {
            using (var _context = new AppDbContext())
            {
                _context.Produto.Add(produto);
                _context.SaveChanges();
            }
        }

        public void Alterar(Produto produto)
        {
            using (var _context = new AppDbContext())
            {
                _context.Entry(produto).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(Produto produto)
        {
            using (var _context = new AppDbContext())
            {
                var entry = _context.Entry(produto);

                if (entry.State == EntityState.Detached)
                    _context.Produto.Attach(produto);

                _context.Produto.Remove(produto);
                _context.SaveChanges();
            }
        }
    }
}
