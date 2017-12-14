using AutoMapper;
using SM.Application.ViewModels;
using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Usuario, UsuarioUsuarioImagemViewModel>();
            CreateMap<UsuarioImagem, UsuarioImagemViewModel>();
            CreateMap<UsuarioImagem, UsuarioUsuarioImagemViewModel>();
        }
        
        // ANTES ERA UTILIZADO DESTA FORMA, DANDO UM OVERRIDE EM "Configure"
        // PORÉM AGORA, NÃO É MAIS NECESSÁRIO, DEVEM SER COLOCADOS OS PERFIS NO CONSTRUTOR DA CLASSE QUE HERDA DE Profile
        // How it was done in 4.x - as of 5.0 this is obsolete:
        // public class OrganizationProfile : Profile 
        // {
        //     protected override void Configure()
        //     {
        //         CreateMap<Foo, FooDto>();
        //     }
        // }
    }
}
