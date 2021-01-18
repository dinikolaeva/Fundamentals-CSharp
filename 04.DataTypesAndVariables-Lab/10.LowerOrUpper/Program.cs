using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int symbolLetter = symbol;

            if (symbolLetter >= 65 && symbolLetter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (symbolLetter >= 97 && symbolLetter <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
