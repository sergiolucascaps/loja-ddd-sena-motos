using SM.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Application.ViewModels;
using SM.Infrastructure.Data.Repository;
using AutoMapper;
using SM.Domain.Entities;

namespace SM.Application
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioAppService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public UsuarioUsuarioImagemViewModel Adicionar(UsuarioUsuarioImagemViewModel usuarioUsuarioImagemViewModel)
        {
            var objUsuario = Mapper.Map<UsuarioUsuarioImagemViewModel, Usuario>(usuarioUsuarioImagemViewModel);
            var objUsuarioImagem = Mapper.Map<UsuarioUsuarioImagemViewModel, UsuarioImagem>(usuarioUsuarioImagemViewModel);

            objUsuario.UsuarioImagem = objUsuarioImagem;

            _usuarioRepository.Adicionar(objUsuario);

            return usuarioUsuarioImagemViewModel;
        }

        public UsuarioViewModel Atualizar(UsuarioViewModel obj)
        {
            var objUsuario = Mapper.Map<UsuarioViewModel, Usuario>(obj);
            _usuarioRepository.Atualizar(objUsuario);

            return obj;
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();

            GC.SuppressFinalize(this);
        }

        public UsuarioViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioRepository.ObterPorCpf(cpf));
        }

        public UsuarioViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioRepository.ObterPorId(id));
        }

        public UsuarioViewModel ObterPorLogin(string Login)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioRepository.ObterPorLogin(Login));
        }

        public IEnumerable<UsuarioViewModel> ObterPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepository.ObterPorNome(nome));
        }

        public IEnumerable<UsuarioViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _usuarioRepository.Remover(id);
        }
    }
}
