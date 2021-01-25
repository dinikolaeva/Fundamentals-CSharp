using System;

namespace E6.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string middleCharacters = string.Empty;

            if (text.Length % 2 ==0)
            {
                middleCharacters = GetMiddleCharOfEvenStringLength(text);
            }
            else
            {
                middleCharacters = GetMiddleCharOfOddStringLength(text);
            }

            Console.WriteLine(middleCharacters);
        }

        private static string GetMiddleCharOfOddStringLength(string text)
        {
            string middleChar = text.Substring((text.Length / 2), 1);

            return middleChar;
        }

        private static string GetMiddleCharOfEvenStringLength(string text)
        {
            string middleChar = text.Substring((text.Length - 1) / 2,2);

            return middleChar;
        }
    }
}
