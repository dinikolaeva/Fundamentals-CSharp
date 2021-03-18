using System;
using System.Globalization;
using System.Linq;

namespace Gr._2._3.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int lastPosition = 0;

            while (command != "Love!")
            {
                string[] cmdArg = command
                    .Split(' ')
                    .ToArray();

                int givenLength = int.Parse(cmdArg[1]);

                lastPosition += givenLength;

                if (lastPosition > neighborhood.Length - 1)
                {
                    lastPosition = 0;
                    neighborhood[lastPosition] -= 2;
                }
                else
                {
                    neighborhood[lastPosition] -= 2;
                }

                if (neighborhood[lastPosition] == 0)
                {
                    Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                }
                else if (neighborhood[lastPosition] < 0)
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            int failCount = neighborhood.Count(x => x > 0);

            if (failCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
        }
    }
}
