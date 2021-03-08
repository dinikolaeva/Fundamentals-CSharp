using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b([A-Z]a?[a-z]+) ([A-Z][a-z]+)\b";

            string text = Console.ReadLine();

            MatchCollection mathcNames = Regex.Matches(text, pattern);

            foreach (var name in mathcNames)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }
    }
}
