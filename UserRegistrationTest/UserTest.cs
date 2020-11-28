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
    }
}
