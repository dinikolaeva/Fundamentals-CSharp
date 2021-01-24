using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            string newString = PrintNewString(input, repeats);

            Console.WriteLine(newString);
        }

        static string PrintNewString(string input, int repeats)
        {
            string repetedString = string.Empty;
            for (int i = 0; i < repeats; i++)
            {
                repetedString += input;
            }

            return repetedString;
        }
    }
}
