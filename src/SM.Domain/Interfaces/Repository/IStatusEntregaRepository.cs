using SM.Domain.Entities;

namespace SM.Domain.Interfaces.Repository
{
    public interface IStatusEntregaRepository : IRepository<StatusEntrega>
    {
        StatusEntrega ObterPorIdStatus(int id);
    }
}
