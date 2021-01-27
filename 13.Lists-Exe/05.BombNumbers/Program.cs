using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            List<int> bombAndPower = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNumber = bombAndPower[0];
                int power = bombAndPower[1];

                if (numbers.Contains(bombNumber))
                {
                    for (int j = 0; j < power; j++)
                    {
                        int firstDetonation = numbers.IndexOf(bombNumber) + 1;

                        if (firstDetonation > numbers.Count-1)
                        {
                            break;
                        }

                        numbers.RemoveAt(firstDetonation);
                    }

                    for (int k = 0; k < power; k++)
                    {
                        int secondDetonation = numbers.IndexOf(bombNumber) - 1;

                        if (secondDetonation < 0)
                        {
                            break;
                        }

                        numbers.RemoveAt(secondDetonation);
                    }
                }
                else
                {
                    break;
                }

                numbers.Remove(bombNumber);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
