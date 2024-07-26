using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "07/01/2024 10:00:00 PM";
            var format = "M/d/yyyy hh:mm:ss tt";

            var date = DateTimeOffset.ParseExact(input, format,
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

            date = date.ToOffset(TimeSpan.FromHours(10));

            var dateString = date.ToString("O");

            Console.WriteLine($"input: {input}");
            Console.WriteLine($"dateString: {dateString}");
        }
    }
}
