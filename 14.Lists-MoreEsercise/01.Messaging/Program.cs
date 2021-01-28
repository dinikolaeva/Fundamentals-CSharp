using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            string message = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sumOfDigits = 0;

                while (currentNumber > 0)
                {
                    int nextNumber = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    sumOfDigits += nextNumber;
                }

                if (sumOfDigits >= text.Length)
                {
                    sumOfDigits -= text.Length;
                }

                message += text[sumOfDigits];
                text = text.Remove(sumOfDigits, 1);
            }

            Console.WriteLine(message);
        }
    }
}