namespace SM.Infrastructure.Data.Migrations
{
    using Domain.Entities;
    using SM.Infrastructure.Data.Context;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SenaMotosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SenaMotosContext context)
        {
            // Tab_Status_Venda
            Context_Tab_Status_Venda(ref context);

            // Tab_Status_Entrega
            Context_Tab_Status_Entrega(ref context);

            // Tab_Status_Negociacao
            Context_Tab_Status_Negociacao(ref context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        #region Context_Tab_Status_Venda

        private void Context_Tab_Status_Venda(ref SenaMotosContext context)
        {
            context.Tab_Status_Venda.AddOrUpdate(
                p => p.Des_Status_Venda,
                new StatusVenda { Idf_Status_Venda = 1, Des_Status_Venda = "Aguardando Confirmação de Pagamento", Dta_Cadastro = DateTime.Now },
                new StatusVenda { Idf_Status_Venda = 2, Des_Status_Venda = "Pagamento Confirmado", Dta_Cadastro = DateTime.Now },
                new StatusVenda { Idf_Status_Venda = 3, Des_Status_Venda = "Venda Cancelada", Dta_Cadastro = DateTime.Now },
                new StatusVenda { Idf_Status_Venda = 4, Des_Status_Venda = "Venda Concluída", Dta_Cadastro = DateTime.Now }
                );
        }

        #endregion

        #region Context_Tab_Status_Entrega

        private void Context_Tab_Status_Entrega(ref SenaMotosContext context)
        {
            context.Tab_Status_Entrega.AddOrUpdate(
                p => p.Des_Status_Entrega,
                new StatusEntrega { Idf_Status_Entrega = 1, Des_Status_Entrega = "Aguardando Envio", Dta_Cadastro = DateTime.Now },
                new StatusEntrega { Idf_Status_Entrega = 2, Des_Status_Entrega = "Em transito", Dta_Cadastro = DateTime.Now },
                new StatusEntrega { Idf_Status_Entrega = 3, Des_Status_Entrega = "Falha na Entrega", Dta_Cadastro = DateTime.Now },
                new StatusEntrega { Idf_Status_Entrega = 4, Des_Status_Entrega = "Entregue", Dta_Cadastro = DateTime.Now }
                );
        }

        #endregion

        #region Context_Tab_Status_Negociacao

        private void Context_Tab_Status_Negociacao(ref SenaMotosContext context)
        {
            context.Tab_Status_Negociacao.AddOrUpdate(
                p => p.Des_Status_Negociacao,
                new StatusNegociacao { Idf_Status_Negociacao = 1, Des_Status_Negociacao = "Em Negociação", Dta_Cadastro = DateTime.Now },
                new StatusNegociacao { Idf_Status_Negociacao = 2, Des_Status_Negociacao = "Deu Negocio", Dta_Cadastro = DateTime.Now },
                new StatusNegociacao { Idf_Status_Negociacao = 3, Des_Status_Negociacao = "Não deu Negocio", Dta_Cadastro = DateTime.Now }
                );
        }

        #endregion

    }
}
