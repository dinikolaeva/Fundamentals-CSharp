using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    integers.RemoveAll(n => n == element);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    integers.Insert(index, element);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', integers));
        }
    }
}
