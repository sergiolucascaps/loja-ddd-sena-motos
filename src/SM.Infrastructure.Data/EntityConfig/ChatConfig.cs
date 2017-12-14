using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class ChatConfig : EntityTypeConfiguration<Chat>
    {
        public ChatConfig()
        {
            HasKey(c => c.Idf_Chat);

            Property(c => c.Des_Mensagem_Chat)
                .HasMaxLength(500)
                .IsRequired();

            Property(c => c.Dta_Cadastro)
                .IsRequired();

            HasRequired(t => t.Negociacao)
                .WithMany(c => c.Chats)
                .HasForeignKey(t => t.Idf_Negociacao);

            //Property(c => c.Idf_Negociacao)
            //    .IsRequired();

            //HasRequired(c => c.Negociacao);

            ToTable("Tab_Negociacao_Chat");
        }
    }
}
