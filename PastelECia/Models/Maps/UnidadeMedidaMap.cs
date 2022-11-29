using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models.Maps
{
    public class UnidadeMedidaMap : EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaMap()
        {
            ToTable("UnidadeMedida");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id_umd");
            Property(x => x.Nome).IsRequired().HasColumnName("Nome_umd").HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_umd").HasColumnType("datetime");
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_umd");
        }
    }
}
