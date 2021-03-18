using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItem = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] cmdArgs = command
                    .Split(" - ");

                string currentCommand = cmdArgs[0];
                string item = cmdArgs[1];

                switch (currentCommand)
                {
                    case "Collect":
                        if (!collectingItem.Contains(item))
                        {
                            collectingItem.Add(item);
                        }
                        break;
                    case "Drop":
                        if (collectingItem.Contains(item))
                        {
                            collectingItem.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] items = item.Split(':');
                        string oldItem = items[0];
                        string newItem = items[1];

                        if (collectingItem.Contains(oldItem))
                        {
                            int index = collectingItem.IndexOf(oldItem);
                            collectingItem.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if (collectingItem.Contains(item))
                        {
                            collectingItem.Remove(item);
                            collectingItem.Add(item);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", collectingItem));
        }
    }
}
