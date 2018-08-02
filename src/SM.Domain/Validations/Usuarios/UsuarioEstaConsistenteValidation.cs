using DomainValidation.Validation;
using SM.Domain.Entities;
using SM.Domain.Specifications.Usuarios;

namespace SM.Domain.Validations.Usuarios
{
    public class UsuarioEstaConsistenteValidation : Validator<Usuario>
    {
        public UsuarioEstaConsistenteValidation()
        {
            var CPFCliente = new UsuarioDeveTerCpfValidoSpecification();
            var EmailCliente = new UsuarioDeveTerEmailValidoSpecification();

            base.Add("CPFCliente", new Rule<Usuario>(CPFCliente, "Cliente informou um CPF inválido"));
            base.Add("EmailCliente", new Rule<Usuario>(EmailCliente, "Cliente informou um e-mail inválido"));
        }
    }
}
