using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class VendaConfig : EntityTypeConfiguration<Venda>
    {
        public VendaConfig()
        {
            HasKey(v => v.Idf_Venda);

            Property(v => v.Qtd_Produtos)
                .IsRequired();

            Property(v => v.Vlr_Final_Venda)
                .IsOptional(); // Vai que algum coração bondoso gosta de fazer doações ne?

            Property(v => v.Dta_Cadastro)
                .IsRequired();

            //fk's
            Property(v => v.Idf_Status_Venda)
                .IsRequired();

            Property(v => v.Idf_Negociacao)
                .IsRequired();

            HasRequired(v => v.Negociacao);

            ToTable("Tab_Venda");
        }
    }
}
