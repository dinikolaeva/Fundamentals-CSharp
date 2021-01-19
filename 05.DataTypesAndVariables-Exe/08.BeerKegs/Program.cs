using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string biggestModel = "";

            for (int i = 0; i < inputLines; i++)
            {
                string modelOfKeg = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                double volumeOfKeg = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;

                if (volumeOfKeg > maxVolume)
                {
                    maxVolume = volumeOfKeg;
                    biggestModel = modelOfKeg;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
