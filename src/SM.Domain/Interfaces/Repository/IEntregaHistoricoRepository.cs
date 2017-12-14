using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IEntregaHistoricoRepository : IRepository<EntregaHistorico>
    {
        IEnumerable<EntregaHistorico> ObterPorIdEntrega(Guid id);
    }
}
