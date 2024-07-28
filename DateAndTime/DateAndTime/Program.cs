using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timestamp = 1722174627;

            var date = DateTimeOffset.FromUnixTimeSeconds(timestamp);

            var unixDateStart = new DateTime(1970,01,01,0,0,0,DateTimeKind.Utc);

            var date2 = unixDateStart.AddSeconds(timestamp);

            Console.WriteLine(date2);
        }
    }
}
