using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTimeOffset(2024,7,1,15,0,0, TimeSpan.FromHours(-5));

            Console.WriteLine(date);
            Console.WriteLine(date.UtcDateTime.IsDaylightSavingTime());
            Console.WriteLine("Kind: "+date.UtcDateTime.Kind);

            Console.WriteLine(DateTime.Now.AddMonths(3).AddDays(1).IsDaylightSavingTime());
            Console.WriteLine("kind: "+DateTime.Now.Kind);

        }
    }
}
