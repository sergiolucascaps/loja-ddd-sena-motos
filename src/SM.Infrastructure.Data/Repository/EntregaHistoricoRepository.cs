using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class EntregaHistoricoRepository : Repository<EntregaHistorico>, IEntregaHistoricoRepository
    {
        public EntregaHistoricoRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public IEnumerable<EntregaHistorico> ObterPorIdEntrega(Guid id)
        {
            return Buscar(eh => eh.Idf_Entrega.Equals(id)).OrderBy(eh => eh.Dta_Cadastro).ToList();
        }
    }
}
