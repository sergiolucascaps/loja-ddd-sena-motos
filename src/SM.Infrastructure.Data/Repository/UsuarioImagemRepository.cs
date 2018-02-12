using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class UsuarioImagemRepository : Repository<UsuarioImagem>, IUsuarioImagemRepository
    {
        public UsuarioImagem ObterPorIdUsuario(Guid id)
        {
            return Buscar(ui => ui.Idf_Usuario.Equals(id)).FirstOrDefault();
        }
    }
}
