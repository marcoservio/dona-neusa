using PastelECia.Dados.EfCore;
using PastelECia.Models;
using PastelECia.Models.Maps;

using System.Data.Entity;

namespace PastelECia.Dados.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(StringConexao.ConnString) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<VersaoSistema> VersaoSistema { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new VersaoSistemaMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
        }
    }
}
