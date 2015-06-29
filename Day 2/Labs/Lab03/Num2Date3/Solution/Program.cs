using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Program
    {
        enum MonthName
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a year: ");
                int year = int.Parse(Console.ReadLine());

                int maxDays = 365;
                if (DateTime.IsLeapYear(year))
                {
                    maxDays = 366;
                    monthDays[1] = 29;
                }

                Console.Write("Please enter a number between 1 and {0}: ", maxDays);
                int dayNumber = int.Parse(Console.ReadLine());

                if (dayNumber < 1 || dayNumber > maxDays)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Day number must be between 1 and {0}", maxDays));
                }

                Console.Write("Day number {0} is ", dayNumber);

                int monthNumber = 1;

                foreach (int numDays in monthDays)
                {
                    if (dayNumber <= numDays)
                    {
                        break;
                    }
                    else
                    {
                        dayNumber -= numDays;
                        monthNumber++;
                    }
                }

                MonthName monthName = (MonthName)monthNumber;
                Console.WriteLine("{0} {1}.", monthName, dayNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Do not change anything below this line
        static int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
