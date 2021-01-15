using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOfN = 0;

            for (int i = 1; i <= (n * 2); i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                sumOfN += n;
            }

            Console.WriteLine($"Sum: {sumOfN/2}");
        }
    }
}
