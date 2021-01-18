using System;

namespace _02.PoundsТoDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal dollars = 1.31M;

            decimal dollarsChange = decimal.Parse(Console.ReadLine());

            decimal britishPounds = dollarsChange * dollars;

            Console.WriteLine($"{britishPounds:f3}");
        }
    }
}
