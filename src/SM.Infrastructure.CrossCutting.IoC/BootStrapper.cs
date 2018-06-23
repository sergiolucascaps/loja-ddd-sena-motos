using SimpleInjector;
using SM.Application;
using SM.Application.Interfaces;
using SM.Domain.Interfaces.Repository;
using SM.Domain.Interfaces.Services;
using SM.Domain.Services;
using SM.Infrastructure.Data.Context;
using SM.Infrastructure.Data.Interfaces;
using SM.Infrastructure.Data.Repository;
using SM.Infrastructure.Data.UnitOfWork;

namespace SM.Infrastructure.CrossCutting.IoC
{
    public class BootStrapper
    {
        /// <summary>
        /// Exemplo explicativo: Quando eu disser que tenho um IUsuarioAppService eu quero que me seja dado um objeto do tipo UsuarioAppService.
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterServices(Container container)
        {

            // Lifestyle.Transient => Uma instância para cada solicitação
            // Lifestyle.Singleton => Uma instância única para a classe
            // Lifestyle.Scoped => Uma instância única para o request

            // APP
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);

            // Dados
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<SenaMotosContext>(Lifestyle.Scoped);
        }
    }
}
