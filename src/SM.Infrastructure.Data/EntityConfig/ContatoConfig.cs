using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    // Fluent API
    public class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            //HasKey(c => new { c.Idf_Contato, c.Dta_Cadastro}); Exemplo: de Criação de chave composta.
            HasKey(c => c.Idf_Contato);

            Property(c => c.Des_Eml_Contato)
                .HasMaxLength(254);

            Property(c => c.Dta_Cadastro)
                .IsRequired();

            Property(c => c.Dta_Alteracao);

            Property(c => c.Idf_Usuario)
                .IsRequired();

            HasRequired(c => c.Usuario);

            ToTable("Tab_Contato");
        }
    }
}
