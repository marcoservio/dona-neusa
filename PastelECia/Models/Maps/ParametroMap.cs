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
            Property(x => x.DiaLimiteAcesso).IsRequired().HasColumnName("DiaLimiteAcesso_par").HasColumnType("int");
            Property(x => x.CodigoAtivacao).IsRequired().HasColumnName("CodigoAtivacao_par").HasColumnType("varchar").HasMaxLength(30);
        }
    }
}
