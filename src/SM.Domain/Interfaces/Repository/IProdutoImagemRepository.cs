using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IProdutoImagemRepository : IRepository<ProdutoImagem>
    {
        IEnumerable<ProdutoImagem> ObterPorIdProduto(Guid id);
    }
}
