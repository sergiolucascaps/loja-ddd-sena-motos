using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusEntregaRepository : Repository<StatusEntrega>, IStatusEntregaRepository
    {
        public StatusEntregaRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public StatusEntrega ObterPorIdStatus(int id)
        {
            return Buscar(se => se.Idf_Status_Entrega.Equals(id)).FirstOrDefault();
        }
    }
}
