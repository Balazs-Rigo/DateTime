using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var period = TimeSpan.FromSeconds(45);

            var extendedPeriod = period.Multiply(2);

            var timeSpan = new TimeSpan(60, 100, 200);

            Console.WriteLine(timeSpan.Hours);

            Console.WriteLine($"utcnow offset: {DateTimeOffset.UtcNow}");
        }
    }
}
