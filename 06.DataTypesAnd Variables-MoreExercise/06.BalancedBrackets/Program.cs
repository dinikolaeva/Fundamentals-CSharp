using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int countOpenBrackets = 0;
            int countClosedBrackets = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpenBrackets++;
                }
                else if (input == ")")
                {
                    countClosedBrackets++;

                    if (countOpenBrackets - countClosedBrackets != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (countOpenBrackets == countClosedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}


