using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class TelefoneConfig : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfig()
        {
            HasKey(t => t.Idf_Telefone);

            Property(t => t.Num_DDD)
                .IsRequired();

            Property(t => t.Idf_Telefone)
                .IsRequired();

            Property(t => t.Dta_Cadastro)
                .IsRequired();

            Property(t => t.Dta_Alteracao)
                .IsOptional();

            //Property(t => t.Idf_Contato)
            //    .IsRequired();
            //Exemplo: Relação 1 -> M.
            HasRequired(t => t.Contato)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.Idf_Contato);

            ToTable("Tab_Telefone");
        }
    }
}
