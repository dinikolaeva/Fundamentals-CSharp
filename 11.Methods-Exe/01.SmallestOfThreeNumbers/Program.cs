using System;
using System.ComponentModel.DataAnnotations;

namespace _1.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallestNumber = GetSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);
        }

        static int GetSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = 0;

            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                smallestNumber = firstNumber;
            }

            if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                smallestNumber = secondNumber;
            }

            if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                smallestNumber = thirdNumber;
            }

            return smallestNumber;
        }
    }
}
