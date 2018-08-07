using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Domain.Validations.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Tests.Validation
{
    [TestClass]
    public class UsuarioAptoParaCadastroTest
    {
        public Usuario Usuario { get; set; }

        [TestMethod]
        public void UsuarioApto_Validation_True()
        {
            Usuario = new Usuario()
            {
                Num_Cpf = "22012742076",
                Eml_Usuario = "emailunicoteste@hotmail.com"
            };

            var stubRepo = MockRepository.GenerateStub<IUsuarioRepository>();
            stubRepo.Stub(u => u.ObterPorLogin(Usuario.Eml_Usuario)).Return(null);
            stubRepo.Stub(u => u.ObterPorCpf(Usuario.Num_Cpf)).Return(null);

            var usuValidation = new UsuarioAptoParaCadastroValidation(stubRepo);

            Assert.IsTrue(usuValidation.Validate(Usuario).IsValid);
        }

        [TestMethod]
        public void UsuarioApto_Validation_False()
        {
            Usuario = new Usuario()
            {
                Num_Cpf = "22012742076",
                Eml_Usuario = "emailunicoteste@hotmail.com"
            };

            var stubRepo = MockRepository.GenerateStub<IUsuarioRepository>();
            stubRepo.Stub(u => u.ObterPorLogin(Usuario.Eml_Usuario)).Return(Usuario);
            stubRepo.Stub(u => u.ObterPorCpf(Usuario.Num_Cpf)).Return(Usuario);

            var usuValidation = new UsuarioAptoParaCadastroValidation(stubRepo);
            var result = usuValidation.Validate(Usuario);

            Assert.IsFalse(usuValidation.Validate(Usuario).IsValid);
            Assert.IsTrue(result.Erros.Any(e=>e.Message == "CPF já cadastrado! Esqueceu sua senha?"));
            Assert.IsTrue(result.Erros.Any(e=>e.Message == "E-mail já cadastrado! Esqueceu sua senha?"));
        }
    }
}
