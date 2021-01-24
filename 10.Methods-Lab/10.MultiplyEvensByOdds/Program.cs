using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int result = SumOfEvenDigits(input) * SumOfOddDigits(input);
            return result;
        }

        private static int SumOfOddDigits(int input)
        {
            int sumOfOddDigits = 0;

            while (input > 0)
            {
                int nextNumber = input % 10;
                input = input / 10;

                if (nextNumber % 2 == 1)
                {
                    sumOfOddDigits += nextNumber;
                }
            }
            return sumOfOddDigits;
        }

        private static int SumOfEvenDigits(int input)
        {
            int sumOfEvenDigits = 0;

            while (input > 0)
            {
                int nextNumber = input % 10;
                input = input / 10;

                if (nextNumber % 2 == 0)
                {
                    sumOfEvenDigits += nextNumber;
                }
            }
            return sumOfEvenDigits;
        }
    }
}
