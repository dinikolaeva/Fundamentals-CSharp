using System;
using System.Linq;

namespace _6.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int k = i+1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");

        }
    }
}
