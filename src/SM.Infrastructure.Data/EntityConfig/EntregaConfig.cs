using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class EntregaConfig : EntityTypeConfiguration<Entrega>
    {
        public EntregaConfig()
        {
            HasKey(e => e.Idf_Entrega);

            Property(e => e.Des_Iteracao_Entrega)
                .HasMaxLength(500)
                .IsRequired();

            Property(e => e.Dta_Cadastro)
                .IsRequired();

            //fk's
            Property(e => e.Idf_Status_Entrega)
                .IsRequired();

            Property(e => e.Idf_Venda)
                .IsRequired();

            HasRequired(e => e.Venda);

            ToTable("Tab_Entrega");
        }
    }
}
