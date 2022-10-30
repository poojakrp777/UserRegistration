using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UserRegexPattern
    {
        public static void FirstName()
        {
            string[] arr = { "Pooja", "pooja", "poo123", "POoja123" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }

        public static void LastName()
        {
            string[] arr = { "R Gowda", "rgowda", "rgowda234", "Gowda" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
    }
}
