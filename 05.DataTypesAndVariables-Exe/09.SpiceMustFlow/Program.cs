using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int yieldDrops = 10;
            const int consumingSpiceFromWorkers = 26;

            int startingYieldForADay = int.Parse(Console.ReadLine());

            int spiceInStorage = 0;
            int countOfDaysSpend = 0;
            int totalAmount = 0;

            if (startingYieldForADay < 100)
            {
                Console.WriteLine(countOfDaysSpend);
                Console.WriteLine(totalAmount);
            }
            else
            {
                while (startingYieldForADay >= 100)
                {

                    spiceInStorage = startingYieldForADay - consumingSpiceFromWorkers;
                    startingYieldForADay -= yieldDrops;
                    countOfDaysSpend++;
                    totalAmount += spiceInStorage;

                    if (spiceInStorage <= 0)
                    {
                        break;
                    }
                }

                totalAmount -= consumingSpiceFromWorkers;

                Console.WriteLine(countOfDaysSpend);
                Console.WriteLine(totalAmount);
            }
        }
    }
}
