using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class ChatRepository : Repository<Chat>, IChatRepository
    {
        public IEnumerable<Chat> ObterPorIdNegociacao(Guid id)
        {
            return Buscar(c => c.Idf_Negociacao.Equals(id)).OrderBy(a => a.Dta_Cadastro).ToList();
        }
    }
}
