using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SM.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Adicionar(Usuario usuario)
        {
            return _usuarioRepository.Adicionar(usuario);
        }

        public Usuario Atualizar(Usuario usuario)
        {
            return _usuarioRepository.Atualizar(usuario);
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Usuario ObterPorCpf(string cpf)
        {
            return _usuarioRepository.ObterPorCpf(cpf);
        }

        public Usuario ObterPorId(Guid id)
        {
            return _usuarioRepository.ObterPorId(id);
        }

        public Usuario ObterPorLogin(string Login)
        {
            return _usuarioRepository.ObterPorLogin(Login);
        }

        public IEnumerable<Usuario> ObterPorNome(string nome)
        {
            return _usuarioRepository.ObterPorNome(nome);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _usuarioRepository.Remover(id);
        }
    }
}
