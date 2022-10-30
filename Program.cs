using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!...");

            UserRegexPattern.FirstName();
            Console.ReadLine();

            UserRegexPattern.LastName();
            Console.ReadLine();
        }
    }
}
