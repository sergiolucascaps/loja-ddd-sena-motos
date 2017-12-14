using SM.Domain.Entities;
using System;

namespace SM.Domain.Interfaces.Repository
{
    public interface IContatoRepository : IRepository<Contato>
    {
        Contato ObterContatoPorUsuario(Guid id);
    }
}
