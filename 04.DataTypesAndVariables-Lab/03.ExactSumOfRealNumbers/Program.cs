using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber = int.Parse(Console.ReadLine());

            decimal sum = 0M;

            for (int i = 0; i < enterNumber; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
