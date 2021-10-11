using System;

namespace LastName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To RegEx");
            Console.WriteLine("Enter the LastName");
            string LastName = Console.ReadLine();
            ValidateLastname ln = new ValidateLastname();
            bool result = ln.ValidateLastnameCheck(LastName);
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
