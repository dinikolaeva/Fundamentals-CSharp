using System;
using System.Collections.Generic;
using System.Linq;

namespace _004.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (command!= "buy")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string nameOfProduct = cmdArg[0];
                double priceOfProduct = double.Parse(cmdArg[1]);
                double quantityOfProduct = double.Parse(cmdArg[2]);

                List<double> priceAndQuantity = new List<double>{priceOfProduct,quantityOfProduct};

                if (!products.ContainsKey(nameOfProduct))
                {
                    products.Add(nameOfProduct, priceAndQuantity);
                }
                else
                {
                    products[nameOfProduct][0] = priceOfProduct;
                    products[nameOfProduct][1] += quantityOfProduct;
                }
                    
                command = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
