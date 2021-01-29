using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                int index = rnd.Next(input.Length);
                string word1 = input[i];
                input[i] = input[index];
                input[index] = word1;              
            }

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
