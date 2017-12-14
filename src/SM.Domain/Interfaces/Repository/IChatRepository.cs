using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IChatRepository : IRepository<Chat>
    {
        IEnumerable<Chat> ObterPorIdNegociacao(Guid id);
    }
}
