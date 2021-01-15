using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplierNumber = int.Parse(Console.ReadLine());

            int result = 0;

            if (multiplierNumber > 10)
            {
                result = inputNumber * multiplierNumber;
                Console.WriteLine($"{inputNumber} X {multiplierNumber} = {result}");
            }

            for (int i = multiplierNumber; i <= 10; i++)
            {
                result = inputNumber * i;

                Console.WriteLine($"{inputNumber} X {i} = {result}");
            }

        }
    }
}
