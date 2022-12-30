//using Microsoft.EntityFrameworkCore;

using PastelECia.Dados.EfCore;
using PastelECia.Models.Maps;

using System.Data.Entity;

namespace PastelECia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(ConnectionString.ConnStringServidor) { }
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<VersaoSistema> VersaoSistema { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new VersaoSistemaMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
        }
    }
}
