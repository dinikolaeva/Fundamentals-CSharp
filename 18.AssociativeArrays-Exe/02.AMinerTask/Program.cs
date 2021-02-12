using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resources = Console.ReadLine();

            Dictionary<string, int> materials = new Dictionary<string, int>();

            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!materials.ContainsKey(resources))
                {
                    materials.Add(resources, 0);
                }
                materials[resources] += quantity;

                resources = Console.ReadLine();
            }

            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
