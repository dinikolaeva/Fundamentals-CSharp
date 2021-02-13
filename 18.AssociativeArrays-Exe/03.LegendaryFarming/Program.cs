using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string legendaryItem = string.Empty;
            bool isObtainedItem = false;

            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        switch (material)
                        {
                            case "shards":
                                keyMaterials["shards"] += quantity;

                                if (keyMaterials["shards"] >= 250)
                                {
                                    legendaryItem = "Shadowmourne";
                                    keyMaterials["shards"] -= 250;
                                    isObtainedItem = true;
                                }
                                break;
                            case "fragments":
                                keyMaterials["fragments"] += quantity;

                                if (keyMaterials["fragments"] >= 250)
                                {
                                    legendaryItem = "Valanyr";
                                    keyMaterials["fragments"] -= 250;
                                    isObtainedItem = true;
                                }
                                break;
                            case "motes":
                                keyMaterials["motes"] += quantity;

                                if (keyMaterials["motes"] >= 250)
                                {
                                    legendaryItem = "Dragonwrath";
                                    keyMaterials["motes"] -= 250;
                                    isObtainedItem = true;
                                }
                                break;
                        }
                        if (isObtainedItem)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }

                if (isObtainedItem)
                {
                    break;
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            Dictionary<string,int> filteredMaterials = keyMaterials
                    .OrderByDescending(n => n.Value)
                    .ThenBy(e => e.Key)
                    .ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in filteredMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var element in junk.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}
