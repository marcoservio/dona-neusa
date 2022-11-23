using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap() 
        {
            ToTable("Produto");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id_prd");
            Property(x => x.Nome_prd).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.Valor_prd).IsRequired().HasColumnType("decimal").HasPrecision(10,2);
        }
    }
}
