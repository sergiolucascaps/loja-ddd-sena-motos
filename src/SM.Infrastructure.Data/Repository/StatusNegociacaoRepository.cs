using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusNegociacaoRepository : Repository<StatusNegociacao>, IStatusNegociacaoRepository
    {
        public StatusNegociacaoRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public StatusNegociacao ObterPorIdStatus(int id)
        {
            return Buscar(sn => sn.Idf_Status_Negociacao.Equals(id)).FirstOrDefault();
        }
    }
}
