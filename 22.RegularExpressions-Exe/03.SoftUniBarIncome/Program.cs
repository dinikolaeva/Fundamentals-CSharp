using System;
using System.Text.RegularExpressions;

namespace _3.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";

            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {
                double currentProductPrice = 0;

                var validProducts = Regex.Matches(input, pattern);

                foreach (Match product in validProducts)
                {
                    var nameOfClient = product.Groups["name"].Value;
                    var nameOfProduct = product.Groups["product"].Value;
                    int count = int.Parse(product.Groups["count"].Value);
                    double price = double.Parse(product.Groups["price"].Value);

                    currentProductPrice = count * price;
                    totalIncome += currentProductPrice;

                    Console.WriteLine($"{nameOfClient}: {nameOfProduct} - {currentProductPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
