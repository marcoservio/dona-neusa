using PastelECia.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Models.Maps
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id_cli");
            Property(x => x.Nome).IsRequired().HasColumnName("Nome_cli").HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.CnpjCpf).IsRequired().HasColumnName("CnpjCpf_cli").HasColumnType("varchar").HasMaxLength(14);
            Property(x => x.Telefone).HasColumnName("Telefone_cli").HasColumnType("varchar").HasMaxLength(11);
            Property(x => x.Email).HasColumnName("Email_cli").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
