using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                inputNumber = int.Parse(Console.ReadLine());
            }

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(inputNumber)}");
            }
        }
    }
}
