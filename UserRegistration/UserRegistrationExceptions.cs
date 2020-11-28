using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    /// <summary>
    /// UserRegistration Exception class
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class UserRegistrationExceptions : Exception
    {
        /// <summary>
        /// declaring the Custom exceptions
        /// </summary>
        public enum ExceptionType
        {
            ENTERED_LESSTHAN_MINCHAR, ENTERED_NUMBER, ENTERED_EMPTY, ENTERED_LOWERCASE,
            ENTERED_SPECIAL_CHARACTER, ENTERED_LESSTHAN_MINUMUM_NUMBER,SHOULDNOTENTER_SPACE_INMOBILENUMBER,
            ENTERED_SPLCHAR, ENTERED_CHAR,ENTERED_WITHOUT_NUMBER,ENTERED_WITHOUT_SPLCHAR,ENTERED_WITHOUT_LOWERCASE,
            ENTERED_WITHOUT_UPPERCASE,ENTERED_CONTINUE_SPLCHAR
        }
        /// <summary>
        /// Declaring the variables
        /// </summary>
        private ExceptionType eNTERED_LESSTHAN_MINCHAR;
        private string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationExceptions"/> class.
        /// </summary>
        /// <param name="eNTERED_LESSTHAN_MINCHAR">The e ntered lessthan minchar.</param>
        /// <param name="message">The message.</param>
        public UserRegistrationExceptions(ExceptionType eNTERED_LESSTHAN_MINCHAR, string message)
        {
            this.eNTERED_LESSTHAN_MINCHAR = eNTERED_LESSTHAN_MINCHAR;
            this.message = message;
        }
    }
}
