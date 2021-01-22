using System;
using System.Linq;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequenses = int.Parse(Console.ReadLine());

            string DNAsequenses = Console.ReadLine();

            int[] bestSequense = new int[lenghtOfSequenses];
            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSumOfSequense = 0;
            int counter = 0;
            int bestSeqenseIndex = 0;

            while (DNAsequenses != "Clone them!")
            {
                int[] currentSequense = DNAsequenses
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                counter++;

                int currentLength = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int sumOfCurrentSequense = 0;

                for (int i = 0; i < currentSequense.Length - 1; i++)
                {
                    if (currentSequense[i] == currentSequense[i + 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }

                    if (currentLength > bestCurrentLength)
                    {
                        bestCurrentLength = currentLength;
                        startIndex = i;
                    }

                    sumOfCurrentSequense += currentSequense[i];

                }

                sumOfCurrentSequense += currentSequense[lenghtOfSequenses - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSumOfSequense = sumOfCurrentSequense;
                    bestSeqenseIndex = counter;
                    bestSequense = currentSequense.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSumOfSequense = sumOfCurrentSequense;
                        bestSeqenseIndex = counter;
                        bestSequense = currentSequense.ToArray();
                    }
                    else if(startIndex == bestStartIndex)
                    {
                        if (sumOfCurrentSequense > bestSumOfSequense)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSumOfSequense = sumOfCurrentSequense;
                            bestSeqenseIndex = counter;
                            bestSequense = currentSequense.ToArray();
                        }
                    }
                }

                DNAsequenses = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSeqenseIndex} with sum: {bestSumOfSequense}.");
            Console.WriteLine(string.Join(" ",bestSequense));
        }
    }
}
