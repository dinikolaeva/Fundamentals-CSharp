using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());

            int sumOfLitres = 0;
            int capacityOfTank = 255;

            for (int i = 0; i < numbersOfLines; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sumOfLitres += litres;

                if (capacityOfTank < sumOfLitres)
                {
                    sumOfLitres -= litres;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }

            Console.WriteLine(sumOfLitres);
        }
    }
}
