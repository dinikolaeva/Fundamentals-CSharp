using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace More1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string pattern = @"[A-z]*[\@|\#|\$|\^][A-z]*";

            foreach (string ticket in tickets)
            {
                bool isValidTicket = false;

                if (ticket.Length == 20)
                {
                    isValidTicket = true;

                    var compare = Regex.Matches(ticket, pattern);


                    int leftCount = 0;
                    int rightCount = 0;

                    foreach (Match currSymbol in compare)
                    {
                        for (int i = 0; i < ticket.Length / 2; i++)
                        {
                            if (ticket[i].ToString() == currSymbol.ToString())
                            {
                                leftCount++;
                            }
                        }

                        for (int i = (ticket.Length - 1) / 2; i >= 0; i--)
                        {
                            if (ticket[i].ToString() == currSymbol.ToString())
                            {
                                rightCount++;
                            }
                        }
                    }


                    /*
                    if (winningSymbols.Success)
                    {
                        int leftCount = 0;

                        for (int i = 0; i < ticket.Length / 2; i++)
                        {
                            if (ticket[i].ToString() == compare)
                            {
                                leftCount++;
                            }
                        }

                        int rightCount = 0;

                        for (int i = (ticket.Length - 1) / 2; i >= 0; i--)
                        {
                            if (ticket[i].ToString() == compare)
                            {
                                rightCount++;
                            }
                        }
                       
                        if (leftCount == rightCount && leftCount >= 6 && leftCount <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {leftCount}{compare}");
                        }
                        else if (rightCount+leftCount == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {10}{compare} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
                    */
                }
            }
        }
    }
}
