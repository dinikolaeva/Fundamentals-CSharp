using System;
using System.Linq;

namespace _8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberToFind = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int sumOfElements = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sumOfElements = arr[i] + arr[j];

                    if (sumOfElements == numberToFind)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");                      
                    }
                }
            }
        }
    }
}
