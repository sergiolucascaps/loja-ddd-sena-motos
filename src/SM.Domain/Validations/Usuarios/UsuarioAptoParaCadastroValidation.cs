using DomainValidation.Validation;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Domain.Specifications.Usuarios;

namespace SM.Domain.Validations.Usuarios
{
    public class UsuarioAptoParaCadastroValidation : Validator<Usuario>
    {
        public UsuarioAptoParaCadastroValidation(IUsuarioRepository usuarioRepository)
        {
            var cpfDuplicado = new UsuarioDevePossuirCpfUnicoSpecification(usuarioRepository);
            var emailDuplicado = new UsuarioDevePossuirEmailUnicoSpecification(usuarioRepository);

            base.Add("cpfDuplicado", new Rule<Usuario>(cpfDuplicado, "CPF já cadastrado! Esqueceu sua senha?"));
            base.Add("emailDuplicado", new Rule<Usuario>(emailDuplicado, "E-mail já cadastrado! Esqueceu sua senha?"));
        }
    }
}
