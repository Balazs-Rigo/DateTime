namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentLocalTime = DateTime.Now;

            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            var currentLocalTimeInSydney = TimeZoneInfo.ConvertTime(currentLocalTime,sydneyTimeZone);

            var currentDateTimeWithOffset = DateTimeOffset.Now;

            var timeZones = TimeZoneInfo.GetSystemTimeZones();

            Console.WriteLine($"Local time: { currentLocalTime}");
            Console.WriteLine($"Sydney time: {currentLocalTimeInSydney}");
            Console.WriteLine($"DateTimeOffset: {DateTimeOffset.Now}");
        }
    }
}
