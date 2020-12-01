using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationdetails
    {
        /// <summary>
        /// Getter or setter the FirstName 
        /// </summary>
        /// <value>
        /// FirstName
        /// </value>
        [Required(ErrorMessage = "Name{0} is requried")]
        [RegularExpression("^[A-Z]{1}[a-zA-Z]{2,}$",ErrorMessage = "Entered FirstName is valid")]
        [StringLength(100,MinimumLength =3,ErrorMessage = "FirstName should contains atleast 3 characteres")]
        public string firstName { get; set; }

        /// <summary>
        /// Getter or setter the LasttName 
        /// </summary>
        /// <value>
        /// LastName
        /// </value>
        [Required(ErrorMessage = "Name{0} is requried")]
        [RegularExpression("^[A-Z]{1}[a-zA-Z]{2,}$", ErrorMessage = "Entered LastName is valid")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "LastName should contains atleast 3 characteres")]
        public string lastName { get; set; }

        /// <summary>
        /// Getter or setter the phoneNumber
        /// </summary>
        /// <value>
        /// phoneNumber
        /// </value>
        [Required(ErrorMessage = "phoneNumber{0} is requried")]
        [RegularExpression("(^[0-9]{1,3}[ ]+)?[6-9]+[0-9]{9}$",ErrorMessage = "Entered PhoneNumber is valid")]
        [StringLength(13,MinimumLength =10,ErrorMessage = "MobileNumber should contain atleast country code")]
        public string phoneNumber { get; set; }

        /// <summary>
        /// Getter or setter the email
        /// </summary>
        /// <value>
        /// email
        /// </value>
        [Required(ErrorMessage = "Email{0} is requried")]
        [RegularExpression("^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$",ErrorMessage = "Entered EmailAddress is valid")]
        public string email { get; set; }

        /// <summary>
        /// Getter or setter the password
        /// </summary>
        /// <value>
        /// password
        /// </value>
        [Required(ErrorMessage = "Password{0} is requried")]
        [RegularExpression("^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$",ErrorMessage ="Entered password is valid")]
        [StringLength(20,MinimumLength = 8,ErrorMessage ="password should contain atleast 8 characters")]
        public string password { get; set; }
    }
}
