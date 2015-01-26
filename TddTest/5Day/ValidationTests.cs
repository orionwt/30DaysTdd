using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TddTest._5Day;

namespace TDD.Test
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public void CheckAuthenticationTest()
        {
            //Arrange
            IAccountDao accDao = new StubAccountDao();
            IHash hash = new StubHash();
            Validation target = new Validation(accDao, hash);
            string id = "admin";//string.Empty;
            string password = "password";//string.Empty;
            bool expected = true;
            bool actual;

            //Act
            actual = target.CheckAuthentication(id, password);

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证这个测试方法的正确性");
        }
    }
}
