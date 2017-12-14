using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface ITelefoneRepository : IRepository<Telefone>
    {
        IEnumerable<Telefone> ObterPorIdContato(Guid id);
    }
}
