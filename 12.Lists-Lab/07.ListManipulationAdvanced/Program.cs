using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
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

            bool isChanged = false;

            while (command[0].ToLower() != "end")
            {

                switch (command[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "remove":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "removeat":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(n => n % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(n => n % 2 != 0)));
                        break;
                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "filter":

                        string surchedNumbers = string.Empty;

                        switch (command[1])
                        {
                            case "<":
                                surchedNumbers = string.Join(" ", numbers
                                    .Where(n => n < int.Parse(command[2])));
                                break;
                            case ">":
                                surchedNumbers = string.Join(" ", numbers
                                    .Where(n => n > int.Parse(command[2])));
                                break;
                            case ">=":
                                surchedNumbers = string.Join(" ", numbers
                                    .Where(n => n >= int.Parse(command[2])));
                                break;
                            case "<=":
                                surchedNumbers = string.Join(" ", numbers
                                    .Where(n => n <= int.Parse(command[2])));
                                break;
                        }
                        Console.WriteLine(surchedNumbers);
                        break;
                }

                command = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
