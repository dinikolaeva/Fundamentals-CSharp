using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToLower() != "end")
            {

                switch (command[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "removeat":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
