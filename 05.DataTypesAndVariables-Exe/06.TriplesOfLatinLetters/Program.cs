using System;

namespace _6.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {

                char firstLetter = (char) ('a'+ i);

                for (int j = 0; j < inputNumber; j++)
                {

                    char secondLetter = (char)('a' + j);

                    for (int k = 0; k < inputNumber; k++)
                    {
                        char thirdLetter = (char)('a' + k);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
