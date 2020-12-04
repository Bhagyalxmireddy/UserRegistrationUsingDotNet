using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace UserRegistration
{
    public class UserValidationUsingLambda
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string EMAIL_PATTERN = "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        public const string MOBILENUMBER_PATTERN = "(^[0-9]{1,3}[ ]+)?[6-9]+[0-9]{9}$";
        public const string PASSWORD_PATTERN = "^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$";

        public  Func<string, bool> namerule = f => Regex.IsMatch(f, NAME_PATTERN) ? true : false;
        public  Func<string, bool> emailRule = f => Regex.IsMatch(f, EMAIL_PATTERN) ? true : false;
        public Func<string, bool> mobileNumberRule = f => Regex.IsMatch(f, MOBILENUMBER_PATTERN) ? true : false;
        public Func<string, bool> passwordRule = f => Regex.IsMatch(f, PASSWORD_PATTERN) ? true : false;



        public bool firstName_Validation(string firstName)
        {
            bool result = namerule(firstName);
            try
            {
                if (result == false)
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
            catch (UserRegistrationExceptions e)
            {
                throw e;
            }
        }
        public bool lastName_Validation(string lastName)
        {
            bool result = namerule(lastName);
            try
            {
                if (result == false)
                {
                    if (lastName.Equals(string.Empty))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_EMPTY,
                                                             "lastName should Not be Empty");
                    if (lastName.Length < 3)
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LESSTHAN_MINCHAR,
                                                              "lastName should be min of 3 char");
                    if (lastName.Any(char.IsDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_NUMBER,
                                                             "lastName should not conatin any number");
                    if (!char.IsUpper(lastName[0]))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_LOWERCASE,
                                                             "lastName should start with uppercase");
                    if (lastName.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.ENTERED_SPECIAL_CHARACTER,
                                                              "lastName should not contain the splCharacteres");

                }
                return result;
            }
            catch (UserRegistrationExceptions e)
            {
                throw e;
            }
        }
        public bool mobileNumber_Validation(string mobileNumber)
        {
            bool result = mobileNumberRule(mobileNumber);
            try
            {
                if (result == false)
                {
                    if (mobileNumber.Length < 10)
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
        public bool passWord_Validation(string passWord)
        {
            bool result = passwordRule(passWord);
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
