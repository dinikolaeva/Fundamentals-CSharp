using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[lines];
            int[] arr2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (i % 2 == 0)
                    {
                        arr1[i] = input[0];
                        arr2[i] = input[1];

                    }
                    else
                    {
                        arr2[i] = input[0];
                        arr1[i] = input[1];
                    }
                }

            }

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }

        }
    }
}
