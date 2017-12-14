using SM.Domain.Entities;

namespace SM.Domain.Interfaces.Repository
{
    public interface IStatusNegociacaoRepository : IRepository<StatusNegociacao>
    {
        StatusNegociacao ObterPorIdStatus(int id);
    }
}
