using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> ObterPorIdAnuncio(Guid id)
        {
            return Buscar(p => p.Idf_Anuncio.Equals(id)).ToList();
        }

        public IEnumerable<Produto> ObterPorIdCategoria(Guid id)
        {
            //return Db.Tab_Categoria.Where(c => c.Idf_Categoria.Equals(id)).Select(c => c.Produtos);
            //return Db.Tab_Categoria.Where(c => c.Idf_Categoria.Equals(id)).Select(c => c.Produtos);

            //return (from p in Db.Tab_Produto
            //        where p.Categorias.All(c => c.Idf_Categoria.Equals(id))
            //        select p).ToList();
            
            //LEMBRAR DE VER PERFORMANCE ENTRE ESTE
            return (IEnumerable<Produto>)Db.Tab_Categoria.Where(c => c.Idf_Categoria.Equals(id)).Select(c => c.Produtos).ToList();
            // E ESTE
            //return Db.Tab_Produto.Where(p => p.Categorias.All(c => c.Idf_Categoria.Equals(id))).ToList();
            
            //return Db.Tab_Produto.Where(p => p.Categorias.Where(c => c.Idf_Categoria.Equals(id)).Select(c => c).ToList().Count > 0).Select(p => p).ToList();
            
        }
    }
}
