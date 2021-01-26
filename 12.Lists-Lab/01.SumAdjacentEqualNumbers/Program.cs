using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int nextNumber = 0;

                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }
                else
                {
                    nextNumber = i + 1;
                }

                if (numbers[i] == numbers[nextNumber])
                {
                    numbers[i] += numbers[nextNumber];
                    numbers.RemoveAt(nextNumber);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
