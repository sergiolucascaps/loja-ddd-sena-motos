using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusNegociacaoRepository : Repository<StatusNegociacao>, IStatusNegociacaoRepository
    {
        public StatusNegociacao ObterPorIdStatus(int id)
        {
            return Buscar(sn => sn.Idf_Status_Negociacao.Equals(id)).FirstOrDefault();
        }
    }
}
