using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> companiesAndID = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] input = command
                    .Split(" -> ")
                    .ToArray();

                string companyName = input[0];
                string employeesID = input[1];

                if (!companiesAndID.ContainsKey(companyName))
                {
                    companiesAndID.Add(companyName, new List<string>());
                }

                if (!companiesAndID[companyName].Contains(employeesID))
                {
                    companiesAndID[companyName].Add(employeesID);
                }

                command = Console.ReadLine();
            }

            foreach (var companyName in companiesAndID.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{companyName.Key}");

                foreach (var employee in companyName.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
