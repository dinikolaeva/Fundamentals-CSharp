using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

namespace _001._Encrypt_SortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] sumOfCharArrays = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                int sum1 = 0;
                int sum2 = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    int sumOfVowel = 0;
                    int sumOfConsonant = 0;
                    bool isVowel = "aeiouAEIOU".IndexOf(input[j]) >= 0;

                    if (isVowel == true)
                    {
                        sumOfVowel += input[j];
                    }
                    else
                    {
                        sumOfConsonant += input[j];
                    }

                    sum1 = sum1 + sumOfVowel * input.Length;
                    sum2 = sum2 + sumOfConsonant / input.Length;

                }

                int sumOfChars = sum1 + sum2;

                sumOfCharArrays[i] = sumOfChars;
            }

            Array.Sort(sumOfCharArrays);

            foreach (var elements in sumOfCharArrays)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
