using System.Data.Entity.ModelConfiguration;

namespace PastelECia.Models.Maps
{
    public class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            ToTable("Parametro");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id_par");
            Property(x => x.DataLimiteAcesso).IsRequired().HasColumnName("DataLimiteAcesso_par").HasColumnType("datetime");
            Property(x => x.CodigoAtivacao).IsRequired().HasColumnName("CodigoAtivacao_par").HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_par").HasColumnType("datetime");
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_par");
        }
    }
}
