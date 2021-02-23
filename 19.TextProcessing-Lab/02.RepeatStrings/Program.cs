using System;
using System.Linq;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var word in input)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
