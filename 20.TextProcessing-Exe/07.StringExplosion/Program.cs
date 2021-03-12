﻿using System;
using System.Text;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int powerOfExplosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == '>')
                {
                    powerOfExplosion += int.Parse(input[i + 1].ToString());
                    sb.Append(current);
                }
                else if (powerOfExplosion == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    powerOfExplosion--;
                }
            }

            Console.WriteLine(sb.ToString()); ;
        }
    }
}