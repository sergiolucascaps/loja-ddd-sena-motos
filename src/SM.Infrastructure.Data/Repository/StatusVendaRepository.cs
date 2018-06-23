using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusVendaRepository : Repository<StatusVenda>, IStatusVendaRepository
    {
        public StatusVendaRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public StatusVenda ObterPorIdStatus(int id)
        {
            return Buscar(sv => sv.Idf_Status_Venda.Equals(id)).FirstOrDefault();
        }
    }
}
