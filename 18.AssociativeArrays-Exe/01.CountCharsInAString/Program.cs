using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()
                .ToCharArray();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }

                if (!letters.ContainsKey(text[i]))
                {
                    letters.Add(text[i], 0);
                }
                letters[text[i]]++;
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
