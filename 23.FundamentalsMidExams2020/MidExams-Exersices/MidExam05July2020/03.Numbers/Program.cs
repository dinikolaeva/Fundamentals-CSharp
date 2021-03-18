using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace July_3.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> sortedNumbers = new List<int>();

            double averageNumber = numbers.Sum() * 1.0 / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count < 2)
                {
                    Console.WriteLine("No");
                    break;
                }

                if (numbers[i] > averageNumber)
                {
                    sortedNumbers.Add(numbers[i]);
                }
            }

            sortedNumbers.Sort();
            sortedNumbers.Reverse();

            if (sortedNumbers.Count > 5)
            {
                while (sortedNumbers.Count != 5)
                {
                    sortedNumbers.RemoveAt(sortedNumbers.Count - 1);
                }
            }

            Console.WriteLine(string.Join(' ', sortedNumbers));
        }
    }
}
