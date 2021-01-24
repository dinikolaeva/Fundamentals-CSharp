using System;
using System.Collections.Concurrent;
using System.Security.Claims;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string manipulation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (manipulation)
            {
                case "add":
                    PrintAssembly(firstNum, secondNum);
                    break;
                case "multiply":
                    PrintMultiply(firstNum, secondNum);
                    break;
                case "subtract":
                    PrintSubstract(firstNum, secondNum);
                    break;
                case "divide":
                    PrintDivide(firstNum, secondNum);
                    break;
            }
        }

        private static void PrintAssembly(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }

        private static void PrintMultiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum); ;
        }

        private static void PrintSubstract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void PrintDivide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
