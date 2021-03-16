using System;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            string input = Console.ReadLine();

            var validEmails = Regex.Matches(input, pattern);

            foreach (Match email in validEmails)
            {
                Console.WriteLine($"{email}");
            }
        }
    }
}
