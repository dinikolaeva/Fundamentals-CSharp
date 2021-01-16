using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double extraLightsabres = Math.Ceiling(countOfStudents + (countOfStudents * 0.10));

            int countBelts = 0;

            for (int freeBelts = 6; freeBelts <= countOfStudents; freeBelts+=6)
            {
                countBelts++;
            }

            double totalLightsabresPrice = extraLightsabres * lightsabersPrice;
            double totalRobesPrice = countOfStudents * robesPrice;
            double totalBeltsPrice = (countOfStudents - countBelts) * beltsPrice;

            double totalSum = totalLightsabresPrice + totalRobesPrice + totalBeltsPrice;

            if (budget >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                double neededMoney = totalSum - budget;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }

        }
    }
}
