using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int addWagons = int.Parse(command[1]);
                    wagons.Add(addWagons);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(command[0]) + wagons[i] <= maxCapacity)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
