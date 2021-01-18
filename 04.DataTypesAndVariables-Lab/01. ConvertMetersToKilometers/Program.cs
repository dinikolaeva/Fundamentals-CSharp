using System;

namespace _01._ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            decimal kilometres = (decimal)(metres /1000.0F);
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
