using System;

namespace Gr._2._1._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());

            int neededHour = 0;

            while (numberOfPeople > 0)
            {
                numberOfPeople -= (firstEmployee + secondEmployee + thirdEmployee);
                neededHour++;

                if (neededHour % 4 == 0)
                {
                    neededHour++;
                }
            }

            Console.WriteLine($"Time needed: {neededHour}h.");
        }
    }
}
