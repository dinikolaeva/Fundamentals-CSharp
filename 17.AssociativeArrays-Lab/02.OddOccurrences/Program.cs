using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (var currentWord in words)
            {
                string wordCase = currentWord.ToLower();

                if (output.ContainsKey(wordCase))
                {
                    output[wordCase]++;
                }
                else
                {
                    output.Add(wordCase, 1);
                }
            }

            foreach (var item in output)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
