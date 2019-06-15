using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void CriarEstudante()
        {
            var cliente = new Cliente(new Name("Gustavo", "Cardim"), new Email("gustavo.cardiim@hotmail.com"), new CPF("78945612388"));

            Assert.AreEqual(cliente, cliente);
        }
    }
}
