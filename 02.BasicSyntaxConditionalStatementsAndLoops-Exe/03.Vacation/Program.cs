using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }

           double totalPrice = price * countOfPeople;

            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                int discountOfBusinessGuests = countOfPeople - 10;
                totalPrice = price * discountOfBusinessGuests;
            }
            else if (typeOfGroup == "Regular" && (countOfPeople >= 10 && countOfPeople <= 20))
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
