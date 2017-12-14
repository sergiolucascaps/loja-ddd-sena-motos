using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class ProdutoImagemRepository : Repository<ProdutoImagem>, IProdutoImagemRepository
    {
        public IEnumerable<ProdutoImagem> ObterPorIdProduto(Guid id)
        {
            return Buscar(pi => pi.Idf_Produto.Equals(id)).ToList();
        }
    }
}
