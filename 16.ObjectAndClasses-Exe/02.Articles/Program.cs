using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

            int n = int.Parse(Console.ReadLine());
            Article newArticle = new Article(text[0], text[1], text[2]);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    newArticle.EditContent(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    newArticle.Rename(command[1]);
                }
            }
            Console.WriteLine(newArticle.ToString());
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string EditContent(string newContent)
        {
            Content = newContent;
            return newContent;
        }

        public string ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
            return newAuthor;
        }
        public string Rename(string newTitle)
        {
            Title = newTitle;
            return newTitle;
        }
        public string ToStringMethod()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
