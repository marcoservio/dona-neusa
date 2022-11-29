using System.Data.Entity.ModelConfiguration;

namespace PastelECia.Models.Maps
{
    public class VersaoSistemaMap : EntityTypeConfiguration<VersaoSistema>
    {
        public VersaoSistemaMap()
        {
            ToTable("VersaoSistema");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id_vsi");
            Property(x => x.VersaoSis).IsRequired().HasColumnName("VersaoSistema_vsi").HasColumnType("int");
            Property(x => x.VersaoBanco).IsRequired().HasColumnName("VersaoBanco_vsi").HasColumnType("int");
            Property(x => x.Revisao).IsRequired().HasColumnName("Revisao_vsi").HasColumnType("int");
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_vsi").HasColumnType("datetime");
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_vsi");
        }
    }
}
