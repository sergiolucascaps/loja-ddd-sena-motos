using SM.Domain.Entities;
using System;

namespace SM.Domain.Interfaces.Repository
{
    public interface IUsuarioImagemRepository : IRepository<UsuarioImagem>
    {
        UsuarioImagem ObterPorIdUsuario(Guid id);
    }
}
