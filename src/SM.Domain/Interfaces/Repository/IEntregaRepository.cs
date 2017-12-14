using SM.Domain.Entities;
using System;

namespace SM.Domain.Interfaces.Repository
{
    public interface IEntregaRepository : IRepository<Entrega>
    {
        Entrega ObterPorIdVenda(Guid id);
    }
}
