using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            string command = Console.ReadLine();
             
            while (command != "End")
            {
                string[] operations = command.Split();

                if (operations[0] == "Add")
                {
                    int element = int.Parse(operations[1]);
                    input.Add(element);
                }
                else if (operations[0] == "Insert")
                {
                    int element = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);

                    if (index < 0 || index > input.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        input.Insert(index, element);
                    }
                }
                else if (operations[0] == "Remove")
                {
                    int index = int.Parse(operations[1]);

                    if (index < 0 || index > input.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        input.RemoveAt(index);
                    }
                }
                
                if (operations[0] == "Shift")
                {
                    int count = int.Parse(operations[2]);

                    if (operations[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstElement = input[0];

                            for (int j = 0; j < input.Count-1; j++)
                            {
                                input[j] = input[j + 1];
                            }

                            input[input.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastElement = input[input.Count - 1];

                            for (int j = input.Count - 1; j > 0; j--)
                            {
                                input[j] = input[j - 1];
                            }

                            input[0] = lastElement;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', input));
        }
    }
}
