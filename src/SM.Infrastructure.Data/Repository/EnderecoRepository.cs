using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(SenaMotosContext context)
            : base(context)
        {
            
        }

        public Endereco ObterEnderecoPorIdContato(Guid id)
        {
            return Buscar(e => e.Idf_Contato.Equals(id)).FirstOrDefault();
        }
    }
}
