using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonth = int.Parse(Console.ReadLine());

            if (numberOfMonth == 1)
            {
                Console.WriteLine("January");
            }
            else if (numberOfMonth == 2)
            {
                Console.WriteLine("February");
            }
            else if (numberOfMonth == 3)
            {
                Console.WriteLine("March");
            }
            else if (numberOfMonth == 4)
            {
                Console.WriteLine("April");
            }
            else if (numberOfMonth == 5)
            {
                Console.WriteLine("May");
            }
            else if (numberOfMonth == 6)
            {
                Console.WriteLine("June");
            }
            else if (numberOfMonth == 7)
            {
                Console.WriteLine("July");
            }
            else if (numberOfMonth == 8)
            {
                Console.WriteLine("August");
            }
            else if (numberOfMonth == 9)
            {
                Console.WriteLine("September");
            }
            else if (numberOfMonth == 10)
            {
                Console.WriteLine("Oktomber");
            }
            else if (numberOfMonth == 11)
            {
                Console.WriteLine("November");
            }
            else if (numberOfMonth == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
