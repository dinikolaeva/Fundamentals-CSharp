using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> positiveNum = numbers
                .Where(n => n >= 0)
                .ToList();

            positiveNum.Reverse();

            if (positiveNum.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positiveNum));
            }
        }
    }
}
