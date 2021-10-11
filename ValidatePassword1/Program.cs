using System;

namespace ValidatePassword1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To RegEx");
            ValidatePassword pwd = new ValidatePassword();
            Console.WriteLine("Enter The Password :");
            string Password = Console.ReadLine();
            bool result = pwd.PasswordCheck(Password);
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
