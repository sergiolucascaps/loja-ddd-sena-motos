using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class EntregaHistoricoConfig : EntityTypeConfiguration<EntregaHistorico>
    {
        public EntregaHistoricoConfig()
        {
            HasKey(eh => eh.Idf_Entrega_Historico);

            Property(eh => eh.Des_Iteracao_Entrega)
                .IsRequired()
                .HasMaxLength(500);

            Property(e => e.Dta_Cadastro)
                .IsRequired();

            Property(e => e.Idf_Status_Entrega)
                .IsRequired();

            ToTable("Tab_Entrega_Historico");
        }
    }
}
