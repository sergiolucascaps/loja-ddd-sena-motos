using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class StatusVendaConfig : EntityTypeConfiguration<StatusVenda>
    {
        public StatusVendaConfig()
        {
            HasKey(sv => sv.Idf_Status_Venda);

            Property(sv => sv.Idf_Status_Venda)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true })); // Campo que será usado para Enumeradores na aplicação.

            Property(sv => sv.Des_Status_Venda)
                .HasMaxLength(75)
                .IsRequired();

            Property(sv => sv.Dta_Cadastro)
                .IsRequired();
            
            ToTable("Tab_Status_Venda");
        }
    }
}
