using SM.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class StatusNegociacaoConfig : EntityTypeConfiguration<StatusNegociacao>
    {
        public StatusNegociacaoConfig()
        {
            HasKey(sn => sn.Idf_Status_Negociacao);

            Property(sn => sn.Idf_Status_Negociacao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true })); // Campo que será usado para Enumeradores na aplicação.

            Property(sn => sn.Des_Status_Negociacao)
                .HasMaxLength(75)
                .IsRequired();
            
            Property(sn => sn.Dta_Cadastro)
                .IsRequired();
            
            ToTable("Tab_Status_Negociacao");
        }
    }
}
