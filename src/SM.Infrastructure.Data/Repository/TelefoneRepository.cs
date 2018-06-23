using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public IEnumerable<Telefone> ObterPorIdContato(Guid id)
        {
            return Buscar(t => t.Idf_Contato.Equals(id)).ToList();
        }
    }
}
