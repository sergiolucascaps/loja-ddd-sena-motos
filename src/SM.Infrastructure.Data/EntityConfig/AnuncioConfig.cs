using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class AnuncioConfig : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioConfig()
        {
            HasKey(a => a.Idf_Anuncio);

            Property(a => a.Des_Titulo_Anuncio)
                .HasMaxLength(75)
                .IsRequired();

            Property(a => a.Des_Anuncio)
                .HasMaxLength(500);

            Property(a => a.Flg_Inativo)
                .IsRequired();

            Property(a => a.Dta_Cadastro)
                .IsRequired();

            Property(a => a.Dta_Alteracao)
                .IsOptional();

            //Property(a => a.Idf_Usuario)
            //    .IsRequired();

            HasRequired(t => t.Usuario)
                .WithMany(c => c.Anuncios)
                .HasForeignKey(t => t.Idf_Usuario);

            ToTable("Tab_Anuncio");
        }
    }
}
