using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject11
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        private bool UserName(string firstName)
        {
            throw new NotImplementedException();
        }
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string FirstName = "Shashi";
            //Act
            bool result = UserName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }

    }
}