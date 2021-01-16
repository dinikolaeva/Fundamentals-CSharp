using System;

namespace _4.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverseInput = string.Empty;

            for (int currentLetter = input.Length - 1; currentLetter >= 0; currentLetter--)
            {
                reverseInput += input[currentLetter];
            }
            Console.WriteLine(reverseInput);
        }
    }
}
