using System;

namespace _3.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            string nameOfTheGame = Console.ReadLine();

            double gamePrice = 0;
            double totalSpent = 0;

            while (nameOfTheGame != "Game Time")
            {
                switch (nameOfTheGame)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        nameOfTheGame = Console.ReadLine();
                        continue;
                }

                if (currentBalance >= gamePrice)
                {
                    Console.WriteLine($"Bought {nameOfTheGame}");
                    totalSpent += gamePrice;
                    currentBalance -= gamePrice;
                }
                else if (currentBalance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                    nameOfTheGame = Console.ReadLine();
                    continue;
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                nameOfTheGame = Console.ReadLine();
            }

            if (nameOfTheGame == "Game Time")
            {
            
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");

            }
        }
    }
}
