using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> ObterPorIdAnuncio(Guid id);
        IEnumerable<Produto> ObterPorIdCategoria(Guid id);
    }
}
