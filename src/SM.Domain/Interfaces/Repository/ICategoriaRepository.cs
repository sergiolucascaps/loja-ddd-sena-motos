using SM.Domain.Entities;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> ObterPorTitulo(string titulo);
        IEnumerable<Categoria> ObterPorDescricao(string descricao);
    }
}
