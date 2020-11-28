using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidations
    {
        private const string NAME_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        private const string EMAIL_PATTERN = "^[a-zA-Z0-9]+(.[a-zA-Z0-9]+)*@[a-zA-Z]+.[a-zA-Z]{2,4}(.[a-zA-Z]{2,2})?$";
        private const string MOBILENUMBER_PATTERN = "(^[0-9]{1,3}[ ]+)?[6-9]+[0-9]{9}$";
        private const string PASSWORD_PATTERN = "^ ^(?=.*[a - z])(?=.*[A - Z]).{8,}$";
        public bool firstName_Validation(String firstName)
        {
            if (Regex.IsMatch(firstName, NAME_PATTERN))
                return true;
            return false;
        }
        public bool lastName_Validation(String lastName)
        {
            if (Regex.IsMatch(lastName, NAME_PATTERN))
                return true;
            return false;
        }
        public bool email_Validation(string email)
        {
            if (Regex.IsMatch(email, EMAIL_PATTERN))
                return true;
            return false;
        }
        public bool mobileNumber_Validation(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER_PATTERN))
                return true;
            return false;
        }
        public bool passWord_Validation(string passWord)
        {
            if (Regex.IsMatch(passWord, PASSWORD_PATTERN))
                return true;
            return false;
        }
    }
}
