using System;

namespace _08.DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int divisibleNumber = 3; divisibleNumber <= 100; divisibleNumber += 3)
            {
                Console.WriteLine(divisibleNumber);
            }
        }
    }
}
