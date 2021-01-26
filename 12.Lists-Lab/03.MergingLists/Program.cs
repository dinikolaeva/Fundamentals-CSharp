using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondtList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondtList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondtList[i]);
            }

            if (firstList.Count > secondtList.Count)
            {
                for (int i = secondtList.Count; i < firstList.Count; i++)
                {

                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = firstList.Count; i < secondtList.Count; i++)
                {

                    result.Add(secondtList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
