using System;

namespace _4.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < numbersOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int valueOfLetter = letter;
                totalSum += valueOfLetter;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
