using System;
using System.Linq;

namespace _7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();

            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int currentCounter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (currentElement == arr[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (currentCounter > bestCount)
                {
                    bestCount = currentCounter;
                    bestIndex = i;
                }
            }

            for (int k = 0; k < bestCount; k++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
