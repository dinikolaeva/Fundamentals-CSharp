using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsInTheTrain = int.Parse(Console.ReadLine());
            int[] people = new int[wagonsInTheTrain];
            int totalPeople = 0;

            for (int i = 0; i < wagonsInTheTrain; i++)
            {
                people[i] = int.Parse(Console.ReadLine());              
            }

            for (int j = 0; j < people.Length; j++)
            {

                totalPeople += people[j];

            }

            foreach (var item in people)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}
