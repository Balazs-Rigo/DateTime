using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JSONWithDotNet12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author xavier = new Author()
            {
                Name = "Xavier Morera",
                Courses = new string[] { "Solr","Spark","Jira","Python"}
            };

            Author lars = new Author()
            {
                Name = "lars klint",
                Courses = new string[] { "Solr", "Spark", "Jira", "Python" }
            };

            Author jason = new Author()
            {
                Name = "jason alba",
                Courses = new string[] { "Solr", "Spark", "Jira", "Python" }
            };

            xavier.FavoriteAuthors = new List<Author> { xavier, jason, lars, jason };

            string xavierJson = JsonConvert.SerializeObject(xavier);

            Console.WriteLine(xavierJson);
        }
    }
}
