using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PastelECia.Dados.EfCore
{
    public class VersaoSistemaDao : ICommand<VersaoSistema>, IQuery<VersaoSistema>
    {
        public List<VersaoSistema> ListarTodos()
        {
            using(var _context = new AppDbContext())
            {
                return _context.VersaoSistema.ToList();
            }
        }

        public VersaoSistema BuscarPor(int id)
        {
            using(var _context = new AppDbContext())
            {
                var versao = _context.VersaoSistema.Find(id);

                if (versao == null)
                    throw new Exception($"A versão com o código {id} não existe.");

                return versao;
            }
        }

        public void Incluir(VersaoSistema versao)
        {
            using(var _context = new AppDbContext())
            {
                _context.VersaoSistema.Add(versao);
                _context.SaveChanges();
            }
        }

        public void Alterar(VersaoSistema versao)
        {
            using(var _context = new AppDbContext())
            {
                _context.Entry(versao).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Excluir(VersaoSistema versao)
        {
            using(var _context = new AppDbContext())
            {
                var entry = _context.Entry(versao);

                if(entry.State == EntityState.Detached)
                    _context.VersaoSistema.Attach(versao);

                _context.VersaoSistema.Remove(versao);
                _context.SaveChanges();
            }
        }
    }
}
