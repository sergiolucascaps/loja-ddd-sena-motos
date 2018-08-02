using AutoMapper;
using SM.Application.Interfaces;
using SM.Application.ViewModels;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Services;
using SM.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace SM.Application
{
    public class UsuarioAppService : AppService, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService, IUnitOfWork uow)
            : base(uow)
        {
            _usuarioService = usuarioService;
        }

        public UsuarioUsuarioImagemViewModel Adicionar(UsuarioUsuarioImagemViewModel usuarioUsuarioImagemViewModel)
        {
            var objUsuario = Mapper.Map<UsuarioUsuarioImagemViewModel, Usuario>(usuarioUsuarioImagemViewModel);
            var objUsuarioImagem = Mapper.Map<UsuarioUsuarioImagemViewModel, UsuarioImagem>(usuarioUsuarioImagemViewModel);

            objUsuario.UsuarioImagem = objUsuarioImagem;

            var usuarioReturn = _usuarioService.Adicionar(objUsuario);
            usuarioUsuarioImagemViewModel = Mapper.Map<Usuario, UsuarioUsuarioImagemViewModel>(usuarioReturn);

            if (usuarioReturn.ValidationResult.IsValid)
                Commit();

            return usuarioUsuarioImagemViewModel;
        }

        public UsuarioUsuarioImagemViewModel Atualizar(UsuarioUsuarioImagemViewModel usuarioUsuarioImagemViewModel)
        {
            var objUsuario = Mapper.Map<UsuarioUsuarioImagemViewModel, Usuario>(usuarioUsuarioImagemViewModel);
            var objUsuarioImagem = Mapper.Map<UsuarioUsuarioImagemViewModel, UsuarioImagem>(usuarioUsuarioImagemViewModel);

            objUsuario.UsuarioImagem = objUsuarioImagem;
            _usuarioService.Atualizar(objUsuario);

            Commit();

            return usuarioUsuarioImagemViewModel;
        }

        public void Dispose()
        {
            _usuarioService.Dispose();

            GC.SuppressFinalize(this);
        }

        public UsuarioViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.ObterPorCpf(cpf));
        }

        public UsuarioUsuarioImagemViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Usuario, UsuarioUsuarioImagemViewModel>(_usuarioService.ObterPorId(id));
        }

        public UsuarioViewModel ObterPorLogin(string Login)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.ObterPorLogin(Login));
        }

        public IEnumerable<UsuarioViewModel> ObterPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.ObterPorNome(nome));
        }

        public IEnumerable<UsuarioViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _usuarioService.Remover(id);
            Commit();
        }
    }
}
