using DomainValidation.Interfaces.Specification;
using SM.Domain.Entities;
using SM.Domain.Validations.Documentos;

namespace SM.Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerCpfValidoSpecification : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return CPFValidation.Validar(usuario.Num_Cpf);
        }
    }
}
