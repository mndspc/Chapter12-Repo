using System;
using System.Text.RegularExpressions;
namespace StringAndStringBuilder
{
    //  This program demo. how to use Regex
    class RegexDemo
    {
        static void Main()
        {
            Console.Write("Enter your Email ID:");
            string email = Console.ReadLine();
            string regexPattern = @"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)";
            Regex emailRegex = new Regex(regexPattern);
           if(emailRegex.IsMatch(email))
            {
                Console.WriteLine("Valid Email Address");
            }
            else
            {
                Console.WriteLine("Invalid Email Address");
            }

            Console.Write("Enter your Age in (Yrs):");
            string age = Console.ReadLine();
            Regex numRegex = new Regex("^[0-9]*$");

            if (numRegex.IsMatch(age))
            {
                Console.WriteLine("Valid Age Number");
            }
            else
            {
                Console.WriteLine("Invalid Age Number");
            }

            Console.ReadLine();
        }
    }
}
