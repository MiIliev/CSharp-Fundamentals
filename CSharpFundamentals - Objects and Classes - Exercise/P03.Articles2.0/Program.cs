namespace P03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();
            int numberOfArticles= int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                string title = command[0];
                string content = command[1];
                string author = command[2];
                Article article = new Article(title, content, author);
                articleList.Add(article);
            }
            foreach (Article article in articleList)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    public class Article
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