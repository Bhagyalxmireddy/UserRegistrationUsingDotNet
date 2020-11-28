using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    /// <summary>
    /// UserRegistration Testing Class
    /// </summary>
    [TestClass]
    public class UserTest
    {
        /// <summary>
        /// creating the Object for uservalidations
        /// </summary>
        UserValidations validations = new UserValidations();
        /// <summary>
        /// givenFirstName_WhenProper_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            bool result = validations.firstName_Validation("BhagyaLaxmi");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenFirstName_WhenLessThanMinChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenLessThanMinChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("bh");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should be min of 3 char", e.Message);
            }
        }

        /// <summary>
        /// givenFirstName_WhenHaveSplChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenHaveSplChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("Bh@gi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should not contain the splCharacteres", e.Message);
            }
        }
        /// <summary>
        /// givenFirstName_WhenHaveNum_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenHaveNum_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("Bhagi111");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should not conatin any number",e.Message);
            }
        }
        /// <summary>
        /// givenFirstName_WhenHaveSplCharAndNum_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenHaveSplCharAndNum_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("Bh@gi11");
            }catch(UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should not contain the splCharacteres",e.Message);
            }
           
        }
        /// <summary>
        ///  givenFirstName_WhenHaveNull_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenHaveNull_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should Not be Empty",e.Message);
            }
        }
        /// <summary>
        /// givenFirstName_WhenNotHavingUpperCase_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenFirstName_WhenNotHavingUpperCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("bhagi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("firstName should start with uppercase", e.Message);
            }
        }
        /// <summary>
        ///  givenLastName_WhenProper_ShouldReturnTrue
        /// </summary>

        [TestMethod]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            bool result = validations.lastName_Validation("BhagyaLaxmi");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenLastName_WhenLessThanMinChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenLessThanMinChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("bh");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should be min of 3 char", e.Message);
            }
        }
        /// <summary>
        /// givenLastName_WhenNotHavingUpperCase_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenNotHavingUpperCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.firstName_Validation("bhagi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should start with uppercase", e.Message);
            }
        }
        /// <summary>
        ///givenLastName_WhenHaveSplChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenHaveSplChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.lastName_Validation("Bh@gi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should Contain with uppercase",e.Message);
            }
        }
        /// <summary>
        /// givenLastName_WhenHaveNum_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenHaveNum_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.lastName_Validation("Bhagi111");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should not conatin any number", e.Message);
            }
        }
        /// <summary>
        /// givenLastName_WhenHaveSplCharAndNum_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenHaveSplCharAndNum_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.lastName_Validation("Bh@gi11");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should not contain the splCharacteres", e.Message);
            }
        }
        /// <summary>
        /// givenLastName_WhenHaveNull_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenLastName_WhenHaveNull_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.lastName_Validation("");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("lastName should Not be Empty", e.Message);
            }
        }
        /// <summary>
        /// givenEmailAddress_WhenProper_ShouldReturnTure
        /// </summary>
        [TestMethod]
        public void givenEmailAddress_WhenProper_ShouldReturnTure()
        {
            bool result = validations.email_Validation("abc@gmail.com");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenEmailAddress_WhenWithContiuneSplChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenEmailAddress_WhenWithContiuneSplChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.email_Validation("abc@.gmail.com");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("email should not have Continues splchar", e.Message);
            }
        }
        /// <summary>
        ///givenEmailAddress_WhenEmpty_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenEmailAddress_WhenEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.email_Validation("");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("email should not be empty", e.Message);
            }
        }
        /// <summary>
        /// givenEmailAddress_WhenNotProper_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenEmailAddress_WhenNotProper_ShouldReturnFalse()
        {
            bool result = validations.email_Validation("abc@gmail.in.");
            Assert.IsFalse(result);
        }
        /// <summary>
        /// givenMoblieNumber_WhenProper_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_WhenProper_ShouldReturnTrue()
        {
            bool result = validations.mobileNumber_Validation("91 8464096496");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenMoblieNumber_WhenProperWithOutCountryCode_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_WhenProperWithOutCountryCode_ShouldReturnTrue()
        {
            bool result = validations.mobileNumber_Validation("8464096496");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenMoblieNumber_WhenNotProper_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_WhenNotProper_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.mobileNumber_Validation("846409649");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("MoblieNumber Should Not be Less the 10 numbers", e.Message);
            }
        }
        /// <summary>
        /// givenMoblieNumber_Whenspace_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_Whenspace_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.mobileNumber_Validation("84640964 95");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("There should be a space inbetween the mobile number", e.Message);
            }
        }
        /// <summary>
        /// givenMoblieNumber_WhenNotProperWithChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_WhenNotProperWithChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.mobileNumber_Validation("846409649aa");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Mobile Number should not contain characteres", e.Message);
            }
        }
        /// <summary>
        /// givenMoblieNumber_WhenNotProperWithSplChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenMoblieNumber_WhenNotProperWithSplChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.mobileNumber_Validation("846409649@");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Mobile Number should not contain splchar", e.Message);
            }
        }
        [TestMethod]
        public void givenPassWord_WhenWithOutUpperCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("bhagyalaxmi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should have atleast one lower case", e.Message);
            }
        }
        /// <summary>
        /// givenPassWord_WhenNotProper_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenPassWord_WhenNotProper_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("bhagya");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should be not less than 8 char", e.Message);
            }
        }
        /// <summary>
        /// givenPassWord_WhenNull_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenPassWord_WhenNull_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should not be empty", e.Message);
            }
        }
        /// <summary>
        /// givenPassWord_WhenWithOneAtleatUpper_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenPassWord_WhenWithOneAtleatUpper_ShouldReturnTrue()
        {
            try
            {
                bool result = validations.passWord_Validation("Bhagyalaxmi");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should be have atleast one numbner", e.Message);
            }
        }
        /// <summary>
        ///givenPassWord_WhenWithAtleastOneNumber_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenPassWord_WhenWithAtleastOneNumber_ShouldReturnTrue()
        {
             bool result = validations.passWord_Validation("Bhagyalaxmi1@");
             Assert.IsTrue(result);
        }
        /// <summary>
        /// givenPassWod_WhenWithOutSplChar_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenPassWod_WhenWithOutSplChar_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("Bhagyalaxmi123");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should have exact one splchar",e.Message);
            }
        }
        /// <summary>
        /// givenPassWod_WhenWithOutNumber_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenPassWod_WhenWithOutNumber_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("Bhagyalaxmi@");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should be have atleast one numbner", e.Message);
            }
        }
        /// <summary>
        /// givenPassWod_WhenOutUpperCase_ShouldReturnFalse
        /// </summary>
        [TestMethod]
        public void givenPassWod_WhenOutUpperCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validations.passWord_Validation("bhagyalaxmi@123");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("password should have atleast one upper case", e.Message);
            }
        }
        /// <summary>
        /// givenPassWord_WhenProperCase_ShouldReturnTrue
        /// </summary>
        [TestMethod]
        public void givenPassWord_WhenProperCase_ShouldReturnTrue()
        { 
            bool result = validations.passWord_Validation("Bhagyalaxmi@123");
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenEmails_WithMultipleInputs_ShouldReturnTrue
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void givenEmails_WithMultipleInputs_ShouldReturnTrue(string email)
        {
            bool result = validations.email_Validation(email);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// givenEmails_WithMultipleInputs_WithoutProper_ShouldReturnFalse
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        [DataRow("abc.com")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void givenEmails_WithMultipleInputs_WithoutProper_ShouldReturnFalse(string email)
        {
            bool result = validations.email_Validation(email);
            Assert.IsFalse(result);
        }
    }
}

