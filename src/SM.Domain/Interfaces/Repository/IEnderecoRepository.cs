using SM.Domain.Entities;
using System;

namespace SM.Domain.Interfaces.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Endereco ObterEnderecoPorIdContato(Guid id);
    }
}
