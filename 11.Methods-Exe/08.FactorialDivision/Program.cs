using System;
using System.Dynamic;

namespace E8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double factorialOfFirstNum = GetFirstFactorial(firstNum);
            double factorialOfSecondNum = GetSecondFactorial(secondNum);

            double result = factorialOfFirstNum / factorialOfSecondNum;
            Console.WriteLine($"{result:f2}");
        }

        private static double GetSecondFactorial(double secondNum)
        {
            double result = 1;
            while (secondNum != 1)
            {
                result = result * secondNum;
                secondNum = secondNum - 1;
            }
            return result;
        }

        private static double GetFirstFactorial(double firstNum)
        {
            double result = 1;
            while (firstNum != 1)
            {
                result = result * firstNum;
                firstNum = firstNum - 1;
            }
            return result;
        }
    }
}
