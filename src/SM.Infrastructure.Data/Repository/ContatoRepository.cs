using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public Contato ObterContatoPorUsuario(Guid id)
        {
            return Buscar(c => c.Idf_Usuario.Equals(id)).FirstOrDefault();
        }
    }
}
