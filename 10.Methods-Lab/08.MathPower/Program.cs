using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GiveResultOfPower(number, power);
            Console.WriteLine(result);

        }

        static double GiveResultOfPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
