using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] arr = new int[inputNumber];

            for (int i = 0; i < inputNumber; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = inputNumber - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
