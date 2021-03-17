using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
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
        [TestMethod]
        public void GivenEmail_WhenValidated_ThenReturnsTrue()
        {
            string email = "Shashighebad@gmail.com";
            bool result = Email(email);
            Assert.AreEqual(true, result);
        }
        private bool Email(string email)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GivenMobileNumber_WhenValidated_ThenReturnsTrue()
        {
            string mobileNumber = "91 7778787878";
            bool result = MobileNumber(mobileNumber);
            Assert.AreEqual(true, result);
        }

        private bool MobileNumber(string mobileNumber)
        {
            throw new NotImplementedException();
        }
    }
}
