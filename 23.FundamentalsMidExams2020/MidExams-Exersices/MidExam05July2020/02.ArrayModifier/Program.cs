using System;
using System.Collections.Generic;
using System.Linq;

namespace July_1._SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string command = cmdArgs[0];
                
                switch (command)
                {
                    case "swap":
                        int index1 = int.Parse(cmdArgs[1]);
                        int index2 = int.Parse(cmdArgs[2]);
                        int oldElement = numbers[index1];
                        int newElement = numbers[index2];
                        numbers[index1] = newElement;
                        numbers[index2] = oldElement;
                        break;
                    case "multiply":
                        index1 = int.Parse(cmdArgs[1]);
                        index2 = int.Parse(cmdArgs[2]);
                        int result = numbers[index1] * numbers[index2];
                        numbers[index1] = result;
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
