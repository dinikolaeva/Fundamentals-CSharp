using System;

namespace _2.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int digit = number;
            int sumOfDigits = 0;

            while (digit > 0)
            {
                sumOfDigits += digit % 10;
                digit = digit / 10;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
