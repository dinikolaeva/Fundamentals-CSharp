using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfThePerson = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18 || ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        ticketPrice = 12;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        ticketPrice = 18;
                    }
                    break;
                case "Weekend":
                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18 || ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        ticketPrice = 15;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        ticketPrice = 20;
                    }
                    break;
                case "Holiday":
                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18)
                    {
                        ticketPrice = 5;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        ticketPrice = 12;
                    }
                    else if (ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        ticketPrice = 10;
                    }
                    break;

            }

            if (ticketPrice == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
