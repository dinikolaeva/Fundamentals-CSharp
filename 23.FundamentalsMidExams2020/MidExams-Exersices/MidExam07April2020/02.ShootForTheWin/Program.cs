using System;
using System.Linq;

namespace April_Retake._2.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            string command = Console.ReadLine();
            int countOfShotTargets = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < targets.Length)
                {
                    int currentValue = targets[index];

                    for (int i = 0; i < targets.Length; i++)
                    {

                        if (i != index)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i]>currentValue)
                                {
                                    targets[i] -= currentValue;
                                }
                                else
                                {
                                    targets[i] += currentValue;
                                }
                            }
                        }
                    }

                    targets[index] = -1;
                    countOfShotTargets++;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countOfShotTargets} ->" + " " + string.Join(' ', targets));
        }
    }
}

        
