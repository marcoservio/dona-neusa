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
            Property(x => x.Nome).IsRequired().HasColumnName("Nome_prd").HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Valor).IsRequired().HasColumnName("Valor_prd").HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Quantidade).HasColumnName("Quantidade_prd").HasColumnType("int");
        }
    }
}
