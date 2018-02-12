using SM.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.Idf_Usuario);

            Property(u => u.Nme_Usuario)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.Num_Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(u => u.Eml_Usuario)
                .HasMaxLength(150)
                .IsRequired();

            Property(u => u.Flg_Inativo)
                .IsRequired();

            Property(u => u.Des_Senha)
                .IsRequired();

            Property(u => u.Des_Senha_Hash)
                .IsRequired();

            Property(u => u.Dta_Nascimento)
                .IsRequired();

            Property(u => u.Dta_Cadastro)
                .IsRequired();

            Property(u => u.Dta_Alteracao)
                .IsOptional();

            // Exemplo: Muitos pra Muitos entre Categoria e Usuários. 
            // E esse Mapeamento será feito para uma tabela chamada Tab_Usuario_Categoria
            HasMany(c => c.Categorias)
                .WithMany(u => u.Usuarios)
                .Map(m => m.ToTable("Tab_Usuario_Categoria"));

            ToTable("Tab_Usuario");
        }
    }
}
