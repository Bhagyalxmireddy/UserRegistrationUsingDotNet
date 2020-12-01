using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistration
{
    public class UserValidationTest
    {
        public static void display(string firstName, string lastName, string phoneNumber, string email,string password)
        {
            Console.WriteLine("UseDetails validation");
            Console.WriteLine("====================================");
            UserRegistrationdetails user = new UserRegistrationdetails();

            user.firstName = firstName;
            user.lastName = lastName;
            user.phoneNumber = phoneNumber;
            user.email = email;
            user.password = password;

            ValidationContext context = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("MemberName:{0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("ErrorMsg::{0}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name:" + user.firstName + "" + user.lastName + "\n" + "MobileNumber:" + user.phoneNumber + "\n" + "Email:" + user.email + "\n" + "Password:" + user.password);
            }

        }
    }
}
