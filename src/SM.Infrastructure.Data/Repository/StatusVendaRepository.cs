using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusVendaRepository : Repository<StatusVenda>, IStatusVendaRepository
    {
        public StatusVenda ObterPorIdStatus(int id)
        {
            return Buscar(sv => sv.Idf_Status_Venda.Equals(id)).FirstOrDefault();
        }
    }
}
