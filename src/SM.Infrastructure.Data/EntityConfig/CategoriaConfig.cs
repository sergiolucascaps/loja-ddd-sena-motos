using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(c => c.Idf_Categoria);

            Property(c => c.Des_Titulo_Categoria)
                .IsRequired()
                .HasMaxLength(75);

            Property(c => c.Des_Categoria)
                .HasMaxLength(400);

            Property(c => c.Dta_Cadastro)
                .IsRequired();

            Property(c => c.Dta_Alteracao)
                .IsOptional();

            //HasRequired(c => c.Usuarios);

            // Exemplo: Muitos pra Muitos entre Categoria e Usuários. 
            // E esse Mapeamento será feito para uma tabela chamada Tab_Usuario_Categoria
            HasMany(u => u.Usuarios)
                .WithMany(c => c.Categorias)
                .Map(m => m.ToTable("Tab_Usuario_Categoria"));

            // Exemplo: Muitos pra Muitos entre Categoria e Produto. 
            // E esse Mapeamento será feito para uma tabela chamada Tab_Produto_Categoria
            HasMany(u => u.Produtos)
                .WithMany(c => c.Categorias)
                .Map(m => m.ToTable("Tab_Produto_Categoria"));

            ToTable("Tab_Categoria");
        }
    }
}
