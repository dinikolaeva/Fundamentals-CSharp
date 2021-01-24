using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int countOfProducts = int.Parse(Console.ReadLine());

            PrintResult(product, countOfProducts);
        }

        static void PrintResult(string product, int countOfProducts)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }

            double result = countOfProducts * price;

            Console.WriteLine($"{result:f2}");
        }
    }
}
