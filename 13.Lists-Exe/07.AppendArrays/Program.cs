using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            List<string> result = new List<string>();

            foreach (var elements in input)
            {
                string[] numbers = elements
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var item in numbers)
                {
                    result.Add(item);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
