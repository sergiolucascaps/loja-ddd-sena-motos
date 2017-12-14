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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<UsuarioUsuarioImagemViewModel, Usuario>();
            CreateMap<UsuarioImagemViewModel, UsuarioImagem>();
            CreateMap<UsuarioUsuarioImagemViewModel, UsuarioImagem>();
        }
    }
}
