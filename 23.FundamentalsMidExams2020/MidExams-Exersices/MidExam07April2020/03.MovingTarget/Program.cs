using System;
using System.Collections.Generic;
using System.Linq;

namespace April_Retake._3.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                switch (command)
                {
                    case "Shoot":
                        if (index >= 0 && index < targets.Count)
                        {
                            int power = int.Parse(cmdArgs[2]);
                            targets[index] -= power;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        int value = int.Parse(cmdArgs[2]);

                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int radius = int.Parse(cmdArgs[2]);

                        if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                        {
                            targets.RemoveRange(index - radius, radius * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|',targets));
        }
    }
}
