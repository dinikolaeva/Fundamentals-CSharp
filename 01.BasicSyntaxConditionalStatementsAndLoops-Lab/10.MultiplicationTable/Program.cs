﻿using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = inputNumber * i;
                Console.WriteLine($"{inputNumber} X {i} = {result}");
            }
        }
    }
}
