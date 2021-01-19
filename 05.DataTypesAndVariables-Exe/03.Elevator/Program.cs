using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            //int counter = 0;

            //while (numberOfPeople > 0)
            //{
            //    numberOfPeople = numberOfPeople - capacityOfElevator;
            //    counter++;
            //}

            //Console.WriteLine(counter);

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);

            Console.WriteLine(courses);
        }
    }
}
