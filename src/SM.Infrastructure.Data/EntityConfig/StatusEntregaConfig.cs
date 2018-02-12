using SM.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class StatusEntregaConfig : EntityTypeConfiguration<StatusEntrega>
    {
        public StatusEntregaConfig()
        {
            HasKey(se => se.Idf_Status_Entrega);

            Property(sv => sv.Idf_Status_Entrega)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true })); // Campo que será usado para Enumeradores na aplicação.

            Property(se => se.Des_Status_Entrega)
                .HasMaxLength(75)
                .IsRequired();

            Property(se => se.Dta_Cadastro)
                .IsRequired();

            ToTable("Tab_Status_Entrega");
        }
    }
}
