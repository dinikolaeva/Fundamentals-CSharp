using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (inputNumber % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (inputNumber % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (inputNumber % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (inputNumber % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
