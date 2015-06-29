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
            // Prompt user for a year

            // Prompt user to enter a number between 1 and 
            // 366 if year is a leap year, otherwise 365

            int dayNumber = int.Parse(Console.ReadLine());

            // Throw an exception if value is out of range

            Console.Write("Day number {0} is ", dayNumber);

            int monthNumber = 1;

            foreach (int daysInMonth in monthDays)
            {
                if (dayNumber <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNumber -= daysInMonth;
                    monthNumber++;
                }
            }

            MonthName monthName = (MonthName)monthNumber;
            Console.WriteLine("{0} {1}.", monthName, dayNumber);
        }

        // Do not change anything below this line
        static int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
