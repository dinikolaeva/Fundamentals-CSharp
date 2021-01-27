using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerDeck.Count != 0 && secondPlayerDeck.Count != 0)
            {
                int firstPlayerCard = firstPlayerDeck[0];
                int secondPlayerCard = secondPlayerDeck[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerDeck.Add(firstPlayerCard);
                    firstPlayerDeck.Add(secondPlayerCard);

                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayerDeck.Add(secondPlayerCard);
                    secondPlayerDeck.Add(firstPlayerCard);
                }

                firstPlayerDeck.Remove(firstPlayerCard);
                secondPlayerDeck.Remove(secondPlayerCard);
            }

            if (firstPlayerDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
            }
        }
    }
}
