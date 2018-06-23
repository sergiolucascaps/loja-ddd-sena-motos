using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class ProdutoImagemRepository : Repository<ProdutoImagem>, IProdutoImagemRepository
    {
        public ProdutoImagemRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public IEnumerable<ProdutoImagem> ObterPorIdProduto(Guid id)
        {
            return Buscar(pi => pi.Idf_Produto.Equals(id)).ToList();
        }
    }
}
