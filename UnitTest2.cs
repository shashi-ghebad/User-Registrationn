using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GivenFirstName_WhenValidated_ThenReturnsTrue()
        {
            string userName = "Shashi";

            bool result = UserName(userName);
            Assert.AreEqual(true, result);
        }

        private bool UserName(string userName)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void GivenLastName_WhenValidated_ThenReturnsTrue()
        {
            string lastName = "Ghebad";

            bool result = LastName(lastName);
            Assert.AreEqual(true, result);
        }

        private bool LastName(string lastName)
        {
            throw new NotImplementedException();
        }

    }
}
