using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTestProject6
{
    [TestClass]
    public class UnitTest6
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
            public void GivenPasswordRule1_WhenValidated_ThenReturnsTrue()
            {

                string password = "shashi";
                bool result = Password(password);
                Assert.AreEqual(true, result);
            }

            private bool Password(string password)
            {
                throw new NotImplementedException();

            }
            [TestMethod]
            public void GivenPasswordRule2_WhenValidated_ThenReturnsTrue()
            {

                string password = "Shashi";
                bool result = Password1(password);
                Assert.AreEqual(true, result);
            }

            private bool Password1(string password)
            {
                throw new NotImplementedException();
            }
        }
    }
