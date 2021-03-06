﻿using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class ProdutoImagemConfig : EntityTypeConfiguration<ProdutoImagem>
    {
        public ProdutoImagemConfig()
        {
            HasKey(pi => pi.Idf_Imagem);

            Property(pi => pi.Imagem)
                .IsOptional();

            Property(pi => pi.Dta_Cadastro)
                .IsRequired();

            Property(pi => pi.Dta_Alteracao)
                .IsOptional();

            //Property(pi => pi.Idf_Produto)
            //    .IsRequired();

            HasRequired(t => t.Produto)
                .WithMany(c => c.ProdutoImagens)
                .HasForeignKey(t => t.Idf_Produto);

            ToTable("Tab_Produto_Imagem");
        }
    }
}
