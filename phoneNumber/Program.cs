using phoneNumber;
using System;

namespace ValidatePhnonumber
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To RegEx");


            Console.WriteLine("Enter The Phone Number :");
            string phonenumber = Console.ReadLine();
            ValidatePhonenumber ph = new ValidatePhonenumber();

            bool result = ph.PhonenumberCheck(phonenumber);
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
