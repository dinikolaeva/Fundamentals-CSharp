using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = cmdArgs[0];
                string word = cmdArgs[1];

                switch (command)
                {
                    case "Chat":
                        message.Add(word);
                        break;
                    case "Delete":
                        if (message.Contains(word))
                        {
                            message.Remove(word);
                        }
                        break;
                    case "Edit":
                        string edditedVersion = cmdArgs[2];
                        if (message.Contains(word))
                        {
                            int index = message.IndexOf(word);
                            message.RemoveAt(index);
                            message.Insert(index, edditedVersion);
                        }
                        break;
                    case "Pin":
                        message.Remove(word);
                        message.Add(word);
                        break;
                    case "Spam":
                        for (int i = 1; i < cmdArgs.Length; i++)
                        {
                            message.Add(cmdArgs[i]);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine,message));
        }
    }
}
