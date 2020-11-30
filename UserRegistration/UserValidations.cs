using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidations
    {
        /// <summary>
        /// declaring the constant patterns
        /// </summary>
        private const string NAME_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        private const string EMAIL_PATTERN = "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        private const string MOBILENUMBER_PATTERN = "(^[0-9]{1,3}[ ]+)?[6-9]+[0-9]{9}$";
        private const string PASSWORD_PATTERN = "^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$";
        /// <summary>
        /// First name validation.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationExceptions">
        /// firstName should be min of 3 char
        /// or
        /// firstName should Not be Empty
        /// or
        /// firstName should not conatin any number
        /// or
        /// firstName should not contain the splCharacteres
        /// or
        /// firstName should start with uppercase
        /// </exception>
        public bool firstName_Validation(String firstName)
        {
            bool result = Regex.IsMatch(firstName, NAME_PATTERN);
            try
            {
                if(result == false)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                                                             "firstName should Not be Empty");
                    if (firstName.Length < 3)
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LESSTHAN_MINCHAR, 
                                                              "firstName should be min of 3 char");
                    if (firstName.Any(char.IsDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_NUMBER,
                                                             "firstName should not conatin any number");
                    if (!char.IsUpper(firstName[0]))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LOWERCASE,
                                                             "firstName should start with uppercase");
                    if (firstName.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_SPECIAL_CHARACTER,
                                                              "firstName should not contain the splCharacteres");
                   
                }
                return result;
            }
            catch(UserRegistrationExceptions e)
            {
                throw e;
            }
               
        }
        /// <summary>
        /// Last name validation.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationExceptions">
        /// lastName should be min of 3 char
        /// or
        /// lastName should Not be Empty
        /// or
        /// lastName should not conatin any number
        /// or
        /// lastName should not contain the splCharacteres
        /// or
        /// lastName should Contain with uppercase
        /// </exception>
        public bool lastName_Validation(String lastName)
        {
            bool result = Regex.IsMatch(lastName, NAME_PATTERN);
                try
                {
                    if(result == false)
                    {
                        if (lastName.Equals(string.Empty))
                            throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                                                            "lastName should Not be Empty");
                        if (lastName.Length < 3)
                            throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LESSTHAN_MINCHAR,
                                                                "lastName should be min of 3 char");
                        if (!char.IsUpper(lastName[0]))
                            throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LOWERCASE,
                                                       "lastName should start with uppercase");
                        if (lastName.Any(char.IsDigit))
                             throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_NUMBER,
                                                             "lastName should not conatin any number");
                        
                        if (lastName.Any(char.IsLetterOrDigit))
                            throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_SPECIAL_CHARACTER,
                                                                "lastName should not contain the splCharacteres");                        
                    }
                return result;
                }catch(UserRegistrationExceptions e)
                {
                throw e;
                }
               
        }
        /// <summary>
        /// Emails the validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationExceptions">
        /// email should not have Continues splchar
        /// or
        /// email should not be empty
        /// </exception>
        public bool email_Validation(string email)
        {
            bool result = Regex.IsMatch(email, EMAIL_PATTERN);
            try
            {
                if (result == false)
                {
                    if (email.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_CONTINUE_SPLCHAR,
                            "email should not have Continues splchar");
                    if (email.Contains(string.Empty))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                            "email should not be empty");
                }
                return result;
            } catch (UserRegistrationExceptions e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Mobiles the number validation.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationExceptions">
        /// MoblieNumber Should Not be Less the 10 numbers
        /// or
        /// Mobile Number should not be empty
        /// or
        /// There should be a space inbetween the mobile number
        /// or
        /// Mobile Number should not contain characteres
        /// or
        /// Mobile Number should not contain splchar
        /// </exception>
        public bool mobileNumber_Validation(string mobileNumber)
        {
            bool result = Regex.IsMatch(mobileNumber, MOBILENUMBER_PATTERN);
            try
            {
                if (result == false)
                {
                    if (mobileNumber.Length > 13)
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LESSTHAN_MINUMUM_NUMBER,
                            "MoblieNumber Should Not be Less the 10 numbers");
                    if (mobileNumber.Equals(string.Empty))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                            "Mobile Number should not be empty");
                   
                    if (mobileNumber.Any(char.IsLetter))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_CHAR,
                            "Mobile Number should not contain characteres");
                    if (mobileNumber.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_SPECIAL_CHARACTER,
                           "Mobile Number should not contain splchar and spaces in between number");
                    if (!mobileNumber.Any(char.IsWhiteSpace))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.SHOULDNOTENTER_SPACE_INMOBILENUMBER,
                                        "There should be a space inbetween the mobile number");
                }
                return result;
            }
            catch (UserRegistrationExceptions e)
            {
                throw e;
            }
               
        }
        /// <summary>
        /// Passes the word validation.
        /// </summary>
        /// <param name="passWord">The pass word.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationExceptions">
        /// password should be not less than 8 char
        /// or
        /// password should be have atleast one numbner
        /// or
        /// password should have exact one splchar
        /// or
        /// password should have atleast one lower case
        /// or
        /// password should have atleast one upper case
        /// or
        /// password should not be empty
        /// </exception>
        public bool passWord_Validation(string passWord)
        {
            bool result = Regex.IsMatch(passWord, PASSWORD_PATTERN);
            try
            {
                if (result == false)
                {
                    if (passWord.Equals(string.Empty))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                           "password should not be empty");
                    if (passWord.Length < 8)
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LESSTHAN_MINCHAR,
                            "password should be not less than 8 char");                 
                   
                    if (!passWord.Any(char.IsLower))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_WITHOUT_LOWERCASE,
                            "password should have atleast one lower case");
                    if (!passWord.Any(char.IsUpper))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_WITHOUT_UPPERCASE,
                            "password should have atleast one upper case");
                    if (!passWord.Any(char.IsDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_WITHOUT_NUMBER,
                            "password should be have atleast one numbner");
                    if (!passWord.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_WITHOUT_SPLCHAR,
                            "password should have exact one splchar");

                }
                return result;
            }
            catch (UserRegistrationExceptions e)
            {
                throw e;
             }
          
            
        }
    }
}
