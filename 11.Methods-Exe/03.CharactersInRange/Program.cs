using System;
using System.Linq;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int firstParseChar = firstChar;
            int secondParseChar = secondChar;

            if (firstParseChar > secondParseChar)
            {
                for (int i = secondParseChar + 1; i < firstParseChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = firstParseChar + 1; i < secondParseChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
