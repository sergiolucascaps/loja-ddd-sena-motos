using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public IEnumerable<Telefone> ObterPorIdContato(Guid id)
        {
            return Buscar(t => t.Idf_Contato.Equals(id)).ToList();
        }
    }
}
