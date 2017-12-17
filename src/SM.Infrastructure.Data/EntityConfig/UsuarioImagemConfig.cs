﻿using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class UsuarioImagemConfig : EntityTypeConfiguration<UsuarioImagem>
    {
        public UsuarioImagemConfig()
        {
            HasKey(ui => ui.Idf_Imagem);

            Property(ui => ui.Imagem)
                .IsRequired();

            Property(ui => ui.Dta_Cadastro)
                .IsRequired();

            Property(ui => ui.Dta_Alteracao)
                .IsOptional();

            Property(ui => ui.Idf_Usuario)
                .IsRequired();

            HasRequired(ui => ui.Usuario);

            ToTable("Tab_Usuario_Imagem");
        }
    }
}