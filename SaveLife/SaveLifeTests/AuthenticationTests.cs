using NUnit.Framework;
using SaveLife.Pages;

namespace SaveLifeTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AuthenticateUser_WithCorrectInformation_ReturnsTrue()
        {
            string firstName = "John";
            string lastName = "Smith";

            int result = LoginPage.AuthenticateUser(firstName, lastName);
            int expected = 0;

            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AuthenticateUser_WithFalseInformation_ReturnsFalse()
        {
            string firstName = "Johnny";
            string lastName = "Joestar";

            int result = LoginPage.AuthenticateUser(firstName, lastName);
            int expected = 0;

            Assert.AreEqual(result, expected);
        }
    }
}