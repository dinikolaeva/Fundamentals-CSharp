using System;

namespace E10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetDigitsDivisibleByEight(n);

        }

        private static void GetDigitsDivisibleByEight(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                string currentNumber = i.ToString();
                bool isOdd = false;
                int sumOfDigits = 0;

                foreach (var digit in currentNumber)
                {
                    int parseNum = digit;

                    if (parseNum % 2 != 0)
                    {
                        isOdd = true;
                    }

                    sumOfDigits += parseNum;
                }

                if (sumOfDigits % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
