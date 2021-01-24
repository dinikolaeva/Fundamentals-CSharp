using System;
using System.Threading;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void PrintTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintLine(1, i);
            }

            for (int i = input - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }

    }
}
