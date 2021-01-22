using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();

            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();

            bool isCommon = false;

            foreach (var item in arr2)
            {
                foreach (var index1 in arr1)
                {
                    if (item == index1)
                    {
                        isCommon = true;
                        Console.Write($"{item}{" "}");
                        break;
                    }
                }
            }
        }
    }
}
