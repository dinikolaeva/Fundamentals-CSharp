using System;
using System.Collections.Generic;
using System.Linq;

namespace Gr._2._2.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] cmdArg = command
                    .Split(' ')
                    .ToArray();

                string currentCommand = cmdArg[0];
                string item = cmdArg[1];

                switch (currentCommand)
                {
                    case "Urgent":
                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                        }
                        break;
                    case "Correct":
                        if (groceries.Contains(item))
                        {
                            string newItem = cmdArg[2];
                            int index = groceries.IndexOf(item);
                            groceries.Insert(index, newItem);
                            groceries.Remove(item);
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}
