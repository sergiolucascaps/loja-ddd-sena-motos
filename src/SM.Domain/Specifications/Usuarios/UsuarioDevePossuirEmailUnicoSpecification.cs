using DomainValidation.Interfaces.Specification;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System.Linq;

namespace SM.Domain.Specifications.Usuarios
{
    public class UsuarioDevePossuirEmailUnicoSpecification : ISpecification<Usuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDevePossuirEmailUnicoSpecification(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool IsSatisfiedBy(Usuario usuario)
        {
            return _usuarioRepository.Buscar(u => u.Eml_Usuario == usuario.Eml_Usuario).Count() == 0;
        }
    }
}
