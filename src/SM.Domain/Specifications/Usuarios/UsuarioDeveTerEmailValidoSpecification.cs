using DomainValidation.Interfaces.Specification;
using SM.Domain.Entities;
using SM.Domain.Validations.Documentos;

namespace SM.Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerEmailValidoSpecification : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return EmailValidation.Validate(usuario.Eml_Usuario);
        }
    }
}
