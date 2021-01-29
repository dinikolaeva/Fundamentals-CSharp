using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                var data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();

                var serialNumber = data[0];
                var itemName = data[1];
                var itemQuantity = int.Parse(data[2]);
                var itemPrice = double.Parse(data[3]);
                var priceOfABox = itemQuantity * itemPrice;

                Item newItem = new Item(itemName, itemPrice);

                Box newBox = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = newItem,
                    Quantity = itemQuantity,
                    PriceForABox = priceOfABox
                };

                boxes.Add(newBox);

                command = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{box.SerialNumber}\n-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}\n-- ${box.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string itemName, double itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceForABox { get; set; }
    }
}
