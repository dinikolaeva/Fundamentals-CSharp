using System;
using System.Collections.Generic;
using System.Linq;

namespace _002.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double sumOfLeft = 0;
            double sumOfRight = 0;

            for (int i = 0; i < numbers.Count/2; i++)
            {
                sumOfLeft += numbers[i];

                if (numbers[i] == 0)
                {
                    sumOfLeft *= 0.80;
                }
            }

            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                sumOfRight += numbers[i];

                if (numbers[i] == 0)
                {
                    sumOfRight *= 0.80;
                }
            }

            if (sumOfLeft < sumOfRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumOfLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumOfRight}");
            }
        }
    }
}
