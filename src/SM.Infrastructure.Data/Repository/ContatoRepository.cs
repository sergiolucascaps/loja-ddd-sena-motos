using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public Contato ObterContatoPorUsuario(Guid id)
        {
            return Buscar(c => c.Idf_Usuario.Equals(id)).FirstOrDefault();
        }
    }
}
