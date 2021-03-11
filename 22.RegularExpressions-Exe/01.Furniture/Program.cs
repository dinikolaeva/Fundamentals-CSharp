using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>(?<name>[A-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            var input = Console.ReadLine();

            var matchedItems = Regex.Matches(input, pattern);

            double totalPrice = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                foreach (Match item in matchedItems)
                {
                    var name = item.Groups["name"].Value;
                    double price = double.Parse(item.Groups["price"].Value);
                    int quantity = int.Parse(item.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                    Console.WriteLine($"{name}");
                }

                input = Console.ReadLine();
                matchedItems = Regex.Matches(input, pattern);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
