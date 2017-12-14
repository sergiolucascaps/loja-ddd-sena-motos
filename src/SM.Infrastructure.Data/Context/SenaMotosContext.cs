using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using SM.Infrastructure.Data.EntityConfig;

namespace SM.Infrastructure.Data.Context
{
    public class SenaMotosContext : DbContext
    {
        #region Construtor

        public SenaMotosContext()
            : base("SenaMotos_Connection")
        {

        }

        #endregion

        #region Propriedades Virtuais (Tabs)

        public virtual DbSet<Usuario> Tab_Usuario { get; set; }
        public virtual DbSet<Contato> Tab_Contato { get; set; }
        public virtual DbSet<Endereco> Tab_Endereco { get; set; }
        public virtual DbSet<Telefone> Tab_Telefone { get; set; }
        public virtual DbSet<Categoria> Tab_Categoria { get; set; }
        public virtual DbSet<UsuarioImagem> Tab_Usuario_Imagem { get; set; }
        public virtual DbSet<Produto> Tab_Produto { get; set; }
        public virtual DbSet<ProdutoImagem> Tab_Produto_Imagem { get; set; }
        public virtual DbSet<Anuncio> Tab_Anuncio { get; set; }
        public virtual DbSet<Negociacao> Tab_Negociacao { get; set; }
        public virtual DbSet<Chat> Tab_Negociacao_Chat { get; set; }
        public virtual DbSet<StatusNegociacao> Tab_Status_Negociacao { get; set; }
        public virtual DbSet<Venda> Tab_Venda { get; set; }
        public virtual DbSet<StatusVenda> Tab_Status_Venda { get; set; }
        public virtual DbSet<Entrega> Tab_Entrega { get; set; }
        public virtual DbSet<StatusEntrega> Tab_Status_Entrega { get; set; }
        public virtual DbSet<EntregaHistorico> Tab_Entrega_Historico { get; set; }

        #endregion

        #region Model Creating

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Remover Convenções

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #endregion

            #region Configuração Default do Model Builder

            //Configura as propriedades que comecem com "Idf_" e tenha o nome da classe (Pega o nome da classe por reflexão)
            modelBuilder.Properties()
                .Where(p => p.Name == "Idf_" + p.ReflectedType.Name)
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            #endregion

            #region Configuração Default do Model Builder com Fluent API

            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new ContatoConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new TelefoneConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new UsuarioImagemConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new ProdutoImagemConfig());
            modelBuilder.Configurations.Add(new AnuncioConfig());
            modelBuilder.Configurations.Add(new NegociacaoConfig());
            modelBuilder.Configurations.Add(new StatusNegociacaoConfig());
            modelBuilder.Configurations.Add(new ChatConfig());
            modelBuilder.Configurations.Add(new VendaConfig());
            modelBuilder.Configurations.Add(new StatusVendaConfig());
            modelBuilder.Configurations.Add(new EntregaConfig());
            modelBuilder.Configurations.Add(new StatusEntregaConfig());
            modelBuilder.Configurations.Add(new EntregaHistoricoConfig());

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Save Changes (Override)

        public override int SaveChanges()
        {
            // Percorre as INSERÇÕES inserindo a Data de Cadastro.
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Dta_Cadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Dta_Cadastro").CurrentValue = DateTime.Now;
                    entry.Property("Dta_Alteracao").CurrentValue = (DateTime?)null;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Dta_Cadastro").IsModified = false;
                    entry.Property("Dta_Alteracao").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        #endregion
    }
}
