using SM.Domain.Entities;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterPorCpf(string cpf);
        Usuario ObterPorLogin(string Login);
        IEnumerable<Usuario> ObterPorNome(string nome);
    }
}
