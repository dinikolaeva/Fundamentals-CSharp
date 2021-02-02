using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numbersOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();

                Article newArticle = new Article(input[0],input[1],input[2]);
                articles.Add(newArticle);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }            
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToStringMethod());
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Author = autor;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string ToStringMethod()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
