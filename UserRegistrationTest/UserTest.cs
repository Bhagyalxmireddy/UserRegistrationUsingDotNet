using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserTest
    {
        UserValidations validations = new UserValidations();
        [TestMethod]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            bool result = validations.firstName_Validation("BhagyaLaxmi");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenFirstName_WhenHaveSplChar_ShouldReturnFalse()
        {
            bool result = validations.firstName_Validation("Bh@gi");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenFirstName_WhenHaveNum_ShouldReturnFalse()
        {
            bool result = validations.firstName_Validation("Bhagi111");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenFirstName_WhenHaveSplCharAndNum_ShouldReturnFalse()
        {
            bool result = validations.firstName_Validation("Bh@gi11");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenFirstName_WhenHaveNull_ShouldReturnFalse()
        {
            bool result = validations.firstName_Validation("");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            bool result = validations.lastName_Validation("BhagyaLaxmi");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenLastName_WhenHaveSplChar_ShouldReturnFalse()
        {
            bool result = validations.lastName_Validation("Bh@gi");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenLastName_WhenHaveNum_ShouldReturnFalse()
        {
            bool result = validations.lastName_Validation("Bhagi111");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenLastName_WhenHaveSplCharAndNum_ShouldReturnFalse()
        {
            bool result = validations.lastName_Validation("Bh@gi11");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenLastName_WhenHaveNull_ShouldReturnFalse()
        {
            bool result = validations.lastName_Validation("");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenEmailAddress_WhenProper_ShouldReturnTure()
        {
            bool result = validations.email_Validation("abc@gmail.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenEmailAddress_WhenWithContiuneSplChar_ShouldReturnFalse()
        {
            bool result = validations.email_Validation("abc@.gmail.com");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void givenEmailAddress_WhenNotProper_ShouldReturnFalse()
        {
            bool result = validations.email_Validation("abc@gmail.in.");
            Assert.IsFalse(result);

        }
    }
}

