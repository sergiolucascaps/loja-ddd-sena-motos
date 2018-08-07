using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM.Domain.Entities;
using SM.Domain.Specifications.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Tests.Specification
{
    [TestClass]
    public class CPFValidationTest
    {
        public Usuario Usuario { get; set; }

        [TestMethod]
        public void CPF_Valido_True()
        {
            Usuario = new Usuario()
            {
                Num_Cpf = "08044516999"
            };

            var cpf = new UsuarioDeveTerCpfValidoSpecification();

            Assert.IsTrue(cpf.IsSatisfiedBy(Usuario));
        }

        [TestMethod]
        public void CPF_Valido_False()
        {
            Usuario = new Usuario()
            {
                Num_Cpf = "0804556999"
            };

            var cpf = new UsuarioDeveTerCpfValidoSpecification();

            Assert.IsFalse(cpf.IsSatisfiedBy(Usuario));
        }
    }
}
