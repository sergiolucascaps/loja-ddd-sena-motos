using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class UsuarioImagemRepository : Repository<UsuarioImagem>, IUsuarioImagemRepository
    {
        public UsuarioImagemRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public UsuarioImagem ObterPorIdUsuario(Guid id)
        {
            return Buscar(ui => ui.Idf_Usuario.Equals(id)).FirstOrDefault();
        }
    }
}
