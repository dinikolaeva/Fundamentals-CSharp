using System;

namespace _01._SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintSign(input);
        }

        static void PrintSign(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero.");
            }
        }
    }
}
