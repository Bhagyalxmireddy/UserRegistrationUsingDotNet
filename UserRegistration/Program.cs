using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To UserRegistration Program");
            UserValidationTest.display("Bhagi", "Reddy", "91 9632587410", "puppy@gmail.com", "Bhagi@123");
            //UserValidationTest.display("Bh", "Re", "962587410", "puppy@gmail.com", "Bhagi@");
            GarbageCollections.garbage();
        }
    }
}
