using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string reverse = string.Empty;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverse += command[i];
                }

                Console.WriteLine($"{command} = {reverse}");

                command = Console.ReadLine();
            }
        }
    }
}
