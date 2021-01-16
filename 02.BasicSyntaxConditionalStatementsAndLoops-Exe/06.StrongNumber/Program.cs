using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int tempNumber = inputNumber;

            string currentNumber = inputNumber.ToString();

            int sum = 0;

            for (int i = 0; i < currentNumber.Length; i++)
            {
                int partOfNumber = tempNumber % 10;
                tempNumber = (tempNumber - partOfNumber) / 10;

                int factorial = 1;

                for (int j = 1; j <= partOfNumber; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (sum == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
