using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = GetResultFromOperation(firstNumber, operation, secondNumber);
            Console.WriteLine(Math.Ceiling(result));
        }

        static int GetResultFromOperation(int firstNumber, string operation, int secondNumber)
        {
            double result = 0;

            switch (operation)
            {
                case"/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            return (int)result;
        }
    }
}
