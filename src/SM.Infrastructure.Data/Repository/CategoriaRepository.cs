using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public IEnumerable<Categoria> ObterPorDescricao(string descricao)
        {
            return Buscar(c => c.Des_Categoria.Contains(descricao)).OrderBy(c => c.Des_Categoria).ToList();
        }

        public IEnumerable<Categoria> ObterPorTitulo(string titulo)
        {
            return Buscar(c => c.Des_Titulo_Categoria.Contains(titulo)).OrderBy(c => c.Des_Titulo_Categoria).ToList();
        }
    }
}
