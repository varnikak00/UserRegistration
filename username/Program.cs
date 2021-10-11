using System;

namespace username
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ValidateFirstName fn = new ValidateFirstName();
            Console.WriteLine("Enter The FirstName :");
            String FirstName = Console.ReadLine();
            bool result = fn.firstNameCheck(FirstName);
            if (result == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
