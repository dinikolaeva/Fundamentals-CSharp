using System;

namespace April_Gr._1._1.Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int initialEnergy = int.Parse(Console.ReadLine());
                string command = Console.ReadLine();
                int winsCount = 0;

                while (command != "End of battle")
                {
                    int distance = int.Parse(command);

                    if (initialEnergy < distance)
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {initialEnergy} energy");
                        break;
                    }

                    initialEnergy -= distance;
                    winsCount++;

                    if (winsCount % 3 == 0)
                    {
                        initialEnergy += winsCount;
                    }

                    command = Console.ReadLine();
                }

                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {winsCount}. Energy left: {initialEnergy}");
                }
            }
        }
    }
}
