using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusEntregaRepository : Repository<StatusEntrega>, IStatusEntregaRepository
    {
        public StatusEntrega ObterPorIdStatus(int id)
        {
            return Buscar(se => se.Idf_Status_Entrega.Equals(id)).FirstOrDefault();
        }
    }
}
