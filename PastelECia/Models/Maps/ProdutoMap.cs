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

            HasRequired(x => x.UnidadeMedida)
                .WithMany(u => u.Produtos)
                .HasForeignKey(u => u.UnidadeMedidaId)
                .WillCascadeOnDelete(false);

            Property(x => x.Id).HasColumnName("Id_prd").HasColumnOrder(1);
            Property(x => x.Nome).IsRequired().HasColumnName("Nome_prd").HasColumnType("varchar").HasMaxLength(50).HasColumnOrder(2);
            Property(x => x.Descricao).HasColumnName("Descricao_prd").HasColumnType("varchar").HasMaxLength(70).HasColumnOrder(3);
            Property(x => x.Valor).IsRequired().HasColumnName("Valor_prd").HasColumnType("decimal").HasPrecision(10, 2).HasColumnOrder(4);
            Property(x => x.Quantidade).HasColumnName("Quantidade_prd").HasColumnType("int").HasColumnOrder(5);
            Property(x => x.DataAlteracao).IsRequired().HasColumnName("DataAlteracao_prd").HasColumnType("datetime").HasColumnOrder(6);
            Property(x => x.Inativo).IsRequired().HasColumnName("Inativo_prd").HasColumnOrder(7);
        }
    }
}
