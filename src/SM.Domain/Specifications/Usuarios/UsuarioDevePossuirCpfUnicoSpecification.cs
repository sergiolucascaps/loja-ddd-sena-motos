using DomainValidation.Interfaces.Specification;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;

namespace SM.Domain.Specifications.Usuarios
{
    public class UsuarioDevePossuirCpfUnicoSpecification : ISpecification<Usuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDevePossuirCpfUnicoSpecification(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool IsSatisfiedBy(Usuario usuario)
        {
            return _usuarioRepository.ObterPorCpf(usuario.Num_Cpf) == null;
        }
    }
}
