using System;
using System.Collections.Generic;
using System.Linq;

namespace _003.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> numbers = new List<char>();

            List<char> nonNumbers = new List<char>();

            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    numbers.Add(text[i]);
                    text.Remove(i);
                }
                else
                {
                    nonNumbers.Add(text[i]);
                }
            }

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }


        }
    }
}
