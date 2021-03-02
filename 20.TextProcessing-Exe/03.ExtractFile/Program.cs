using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Split(@"\");

            var fileName = path[path.Length - 1];
            var files = fileName.Split('.');

            string name = files[0];
            string extension = files[1];


            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
