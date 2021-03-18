using System;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine()
                .Split("|")
                .ToArray();

            int currentHealth = health;
            int count = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] cmdArgs = rooms[i].Split(' ');
                string command = cmdArgs[0];
                int number = int.Parse(cmdArgs[1]);

                if (command == "potion")
                {
                    if (currentHealth < 100)
                    {
                        currentHealth += number;

                        if (currentHealth > 100)
                        {
                            int  healdPoints = health - (currentHealth - number);
                            currentHealth = 100;
                            Console.WriteLine($"You healed for {healdPoints} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                        }
                    }

                    Console.WriteLine($"Current health: {currentHealth} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    currentHealth -= number;

                    if (currentHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }

                count++;
            }

            if (count == rooms.Length)
            {

                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {currentHealth}");

            }
        }
    }
}
