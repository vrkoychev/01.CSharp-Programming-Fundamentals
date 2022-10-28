using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ").ToArray();

                string title = data[0];
                string content = data[1];
                string author = data[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string type = Console.ReadLine();

            if (type == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }

            if (type == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }

            if (type == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
