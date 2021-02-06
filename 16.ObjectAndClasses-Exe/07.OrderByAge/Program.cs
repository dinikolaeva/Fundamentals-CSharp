using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<People> people = new List<People>();

            while (input != "End")
            {
                var command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = command[0];
                var ID = command[1];
                int age = int.Parse(command[2]);

                People currentPerson = new People(name, ID, age);
                people.Add(currentPerson);

                input = Console.ReadLine();
            }

            foreach (People person in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class People
    {
        public People(string name, string Id, int age)
        {
            Name = name;
            ID = Id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
