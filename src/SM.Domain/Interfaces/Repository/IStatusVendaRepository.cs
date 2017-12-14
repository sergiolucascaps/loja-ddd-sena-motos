using SM.Domain.Entities;

namespace SM.Domain.Interfaces.Repository
{
    public interface IStatusVendaRepository : IRepository<StatusVenda>
    {
        StatusVenda ObterPorIdStatus(int id);
    }
}
