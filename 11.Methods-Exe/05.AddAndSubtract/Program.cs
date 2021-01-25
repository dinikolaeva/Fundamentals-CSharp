using System;

namespace E5.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int addResult = AddNumbers(num1, num2);
            int substractResult = SubstractNumbers(addResult, num3);
            Console.WriteLine(substractResult);

        }

        private static int SubstractNumbers(int addResult, int num3)
        {
            int substractResult = addResult - num3;
            return substractResult;
        }

        private static int AddNumbers(int num1, int num2)
        {
            int addResult = num1 + num2;
            return addResult;
        }
    }
}
