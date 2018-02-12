using SM.Application.ViewModels;
using SM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioUsuarioImagemViewModel Adicionar(UsuarioUsuarioImagemViewModel usuarioImagemViewModel);
        UsuarioUsuarioImagemViewModel ObterPorId(Guid id);
        UsuarioViewModel ObterPorCpf(string cpf);
        IEnumerable<UsuarioViewModel> ObterTodos();
        UsuarioViewModel ObterPorLogin(string Login);
        UsuarioUsuarioImagemViewModel Atualizar(UsuarioUsuarioImagemViewModel usuarioImagemViewModel);
        IEnumerable<UsuarioViewModel> ObterPorNome(string nome);
        void Remover(Guid id);
    }
}
