using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Interfaces.Services
{
    public interface IUsuarioService : IDisposable
    {
        Usuario Adicionar(Usuario usuario);
        Usuario ObterPorId(Guid id);
        Usuario ObterPorCpf(string cpf);
        IEnumerable<Usuario> ObterTodos();
        Usuario ObterPorLogin(string Login);
        Usuario Atualizar(Usuario usuario);
        IEnumerable<Usuario> ObterPorNome(string nome);
        void Remover(Guid id);
    }
}
