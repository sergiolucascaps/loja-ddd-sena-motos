using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class EntregaRepository : Repository<Entrega>, IEntregaRepository
    {
        public EntregaRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public Entrega ObterPorIdVenda(Guid id)
        {
            return Buscar(e => e.Idf_Venda.Equals(id)).FirstOrDefault();
        }
    }
}
