using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class StatusVendaRepository : Repository<StatusVenda>, IStatusVendaRepository
    {
        public StatusVenda ObterPorIdStatus(int id)
        {
            return Buscar(sv => sv.Idf_Status_Venda.Equals(id)).FirstOrDefault();
        }
    }
}
