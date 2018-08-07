using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM.Domain.Entities;

namespace SM.Domain.Tests.Entity
{
    [TestClass]
    public class UsuarioTest
    {
        public Usuario Usuario { get; set; }

        [TestMethod]
        public void Usuario_ValidarConsistencia_True()
        {
            Usuario = new Usuario
            {
                Num_Cpf = "08044516999",
                Eml_Usuario = "sergiolucascaps@hotmail.com"
            };

            Assert.IsTrue(Usuario.IsValid());
        }

        [TestMethod]
        public void Usuario_ValidarConsistencia_False()
        {
            Usuario = new Usuario
            {
                Num_Cpf = "08044315999",
                Eml_Usuario = "sergiolucascaps2hotmail.com"
            };

            Assert.IsFalse(Usuario.IsValid());
            Assert.IsTrue(Usuario.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um e-mail inválido"));
            Assert.IsTrue(Usuario.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um CPF inválido"));
        }
    }
}
