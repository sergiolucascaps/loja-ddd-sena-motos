using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class EntregaRepository : Repository<Entrega>, IEntregaRepository
    {
        public Entrega ObterPorIdVenda(Guid id)
        {
            return Buscar(e => e.Idf_Venda.Equals(id)).FirstOrDefault();
        }
    }
}
