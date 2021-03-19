using System;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceForASingleEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            double priceOfEggs = priceForASingleEgg * 10;
            double extraApron = Math.Ceiling(countOfStudents + (countOfStudents * 0.20));
            int extraFlour = countOfStudents / 5;

            double totalPrice = (priceOfApron * extraApron) 
                              + (priceOfEggs * countOfStudents) 
                              + priceOfFlour * (countOfStudents - extraFlour);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
