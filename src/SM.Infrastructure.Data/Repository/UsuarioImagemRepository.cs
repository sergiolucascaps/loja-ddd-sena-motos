using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
