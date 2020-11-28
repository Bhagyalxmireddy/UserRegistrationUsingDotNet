using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidations
    {
        private const string NAME_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
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
    }
}
