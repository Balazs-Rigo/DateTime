using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);

            contractDate = ExtendContract(contractDate,1);

            Console.WriteLine(contractDate);

            DateTimeOffset ExtendContract(DateTimeOffset current, int months)
            {
                var newContractDate = current.AddMonths(months).AddTicks(-1);
                
                return new DateTimeOffset(newContractDate.Year, newContractDate.Month,
                    DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month),
                    23,59,59, current.Offset);
            }
        }
    }
}
