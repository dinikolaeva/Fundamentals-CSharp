using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length > 3)
                {
                    if (names.Count == 0)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else
                    {
                        if (!names.Contains(command[0]))
                        {
                            Console.WriteLine($"{command[0]} is not in the list!");
                        }
                        else
                        {
                            names.Remove(command[0]);
                        }
                    }
                }
                else
                {
                    if (names.Count == 0)
                    {
                        names.Add(command[0]);
                    }
                    else
                    {
                        if (!names.Contains(command[0]))
                        {
                            names.Add(command[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[0]} is already in the list!");
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
