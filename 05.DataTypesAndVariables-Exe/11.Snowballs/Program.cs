using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (value >= snowballValue)
                {
                    snowballValue = value;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQality = snowballQuality;
                }

            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {snowballValue} ({bestQality})");

        }
    }
}
