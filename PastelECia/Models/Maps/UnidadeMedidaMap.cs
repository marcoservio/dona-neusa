using System.Data.Entity.ModelConfiguration;
using System.Security.Cryptography.X509Certificates;

namespace PastelECia.Models.Maps
{
    public class UnidadeMedidaMap : EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaMap()
        {
            ToTable("UnidadeMedida");
            HasKey(x => x.Id);
            HasMany(x => x.Produtos).WithRequired(x => x.UnidadeMedida).HasForeignKey(x => x.UnidadeMedidaId);
            Property(x => x.Id).HasColumnName("Id_umd");
            Property(x => x.Nome).IsRequired().HasColumnName("Nome_umd").HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Descricao).HasColumnName("Descricao_umd").HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_umd").HasColumnType("datetime");
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_umd");
        }
    }
}
