using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            string firstWord = input[0];
            string secondWord = input[1];

            var sum = GetSum(firstWord, secondWord);

            Console.WriteLine(sum);
        }

        private static int GetSum(string firstWord, string secondWord)
        {
            var sum = 0;
            var restDigitsSum = 0;

            if (firstWord.Length > secondWord.Length || firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }

                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    restDigitsSum += firstWord[i];
                }
            }
            else if(secondWord.Length > firstWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += secondWord[i] * firstWord[i];
                }
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    restDigitsSum += secondWord[i];
                }
            }

            sum += restDigitsSum;

            return sum;
        }
    }
}
