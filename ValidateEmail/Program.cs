using System;

namespace ValidateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Email :");
            string Email = Console.ReadLine();
            ValidateEmail email = new ValidateEmail();
            bool result = email.ValidateEmailCheck(Email);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
