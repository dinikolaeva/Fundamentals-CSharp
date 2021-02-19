using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> forceUsers = new Dictionary<string, string>();

            while (command != "Lumpawaroo")
            {
                var input = command.Split();

                if (input.Contains("|"))
                {
                    string[] cmdArg = command.Split(" | ");
                    string forceSide = cmdArg[0];
                    string forceUser = cmdArg[1];

                    if (!forceUsers.ContainsKey(forceUser))
                    {
                        forceUsers.Add(forceUser, forceSide);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] cmdArg = command.Split(" -> ");
                    string forceUser = cmdArg[0];
                    string forceSide = cmdArg[1];

                    if (forceUsers.ContainsKey(forceUser))
                    {
                        forceUsers[forceUser] = forceSide;
                    }
                    else
                    {
                        forceUsers.Add(forceUser, forceSide);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                command = Console.ReadLine();
            }

            foreach (var user in forceUsers
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(n => n.Key))
            {
                Console.WriteLine($"Side: {user.Key}, Members: {user.Count()}");

                foreach (var item in user.OrderBy(m => m.Key))
                {
                    Console.WriteLine(($"! {item.Key}"));
                }
            }
        }
    }
}
