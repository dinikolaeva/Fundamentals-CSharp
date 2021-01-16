using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double tottalSum = 0;

            while (inputCoins != "Start")
            {
                double insertCoins = double.Parse(inputCoins);

                if (insertCoins == 0.1 || insertCoins == 0.2 || insertCoins == 0.5 || insertCoins == 1 || insertCoins == 2)
                {
                    tottalSum += insertCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertCoins}");
                }

                inputCoins = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.50;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (tottalSum < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    tottalSum -= productPrice;
                }

                product = Console.ReadLine();
            }

                Console.WriteLine($"Change: {tottalSum:f2}");

        }
    }
}
