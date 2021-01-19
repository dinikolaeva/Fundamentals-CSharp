using System;

namespace _1.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            int sumOfFirstAndSecond = firstNum + secondNum;
            int divideSum = sumOfFirstAndSecond / thirdNum;
            int result = divideSum * forthNum;

            Console.WriteLine(result);
        }
    }
}
