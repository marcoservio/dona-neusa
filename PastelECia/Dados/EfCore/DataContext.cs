using PastelECia.Models.Maps;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Data Source=MARCOSERVIO\\SQLEXPRESS;Initial Catalog=Pastel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }
}
