using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class NegociacaoConfig : EntityTypeConfiguration<Negociacao>
    {
        public NegociacaoConfig()
        {
            HasKey(n => n.Idf_Negociacao);

            Property(n => n.Des_Negociacao)
                .HasMaxLength(75);
            
            Property(n => n.Dta_Inicio_Negociacao)
                .IsRequired();

            Property(n => n.Dta_Fim_Negociacao)
                .IsRequired();

            //FK's
            //Property(n => n.Idf_Anuncio)
            //    .IsRequired();

            HasRequired(t => t.Anuncio)
                .WithMany(c => c.Negociacoes)
                .HasForeignKey(t => t.Idf_Anuncio);

            Property(n => n.Idf_Status_Negociacao)
                .IsRequired();

            //Property(n => n.Idf_Usuario)    // Este é o IDF do Usuario INTERESSADO na no Produto. O Do Anunciante estará presente no anúncio.
            //    .IsRequired();

            //Exemplo: Relação 1 -> M.
            HasRequired(t => t.Usuario)
                .WithMany(c => c.Negociacoes)
                .HasForeignKey(t => t.Idf_Usuario);// Este é o IDF do Usuario INTERESSADO na no Produto. O Do Anunciante estará presente no anúncio.

            ToTable("Tab_Negociacao");
        }
    }
}
