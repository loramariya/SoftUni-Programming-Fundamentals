namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
