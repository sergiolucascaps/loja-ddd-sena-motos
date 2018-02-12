using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SM.Infrastructure.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.Idf_Endereco);

            Property(e => e.Nme_Endereco); // Este Campo servira como um "Apelido" para o endereço. Pra referência do usuário

            Property(e => e.Des_Logradouro)
                .IsRequired();

            Property(e => e.Des_Numero);

            Property(e => e.Des_Complemento)
                .HasMaxLength(256);

            Property(e => e.Des_Bairro);

            Property(e => e.Num_Cep);

            Property(e => e.Des_Cidade)
                .IsRequired()
                .HasMaxLength(75);

            Property(e => e.Des_Estado)
                .HasMaxLength(2);

            Property(e => e.Dta_Cadastro)
                .IsRequired();

            Property(e => e.Dta_Alteracao)
                .IsOptional();

            //Property(e => e.Idf_Contato);
            //Exemplo: Relação 1 -> M.
            HasRequired(c => c.Contato)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(c => c.Idf_Contato);

            ToTable("Tab_Endereco");

        }
    }
}
