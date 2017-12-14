using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Idf_Produto);

            Property(p => p.Des_Nme_Produto)
                .IsRequired()
                .HasMaxLength(75);

            Property(p => p.Des_Produto)
                .IsOptional();

            Property(p => p.Dta_Cadastro)
                .IsRequired();

            Property(p => p.Dta_Alteracao)
                .IsOptional();

            Property(p => p.Vlr_Produto) 
                .IsOptional(); // Quem sabe algum coração bondoso gosta de fazer doações?

            HasRequired(t => t.Anuncio)
                .WithMany(c => c.Produtos)
                .HasForeignKey(t => t.Idf_Anuncio);

            // Exemplo: Muitos pra Muitos entre Categoria e Produto. 
            // E esse Mapeamento será feito para uma tabela chamada Tab_Produto_Categoria
            HasMany(u => u.Categorias)
                .WithMany(c => c.Produtos)
                .Map(m => m.ToTable("Tab_Produto_Categoria"));

            ToTable("Tab_Produto");
        }
    }
}
