using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 and 365: ");
            int dayNumber = int.Parse(Console.ReadLine());
            Console.Write("Day number {0} is ", dayNumber);

            int monthNumber = 1;

            // Replace 12 if blocks with a loop that 
            // iterates over the monthDays collection
            // (defined below).

            string monthName = "";

            // Create an enumeration named MonthName defining 
            // the names of the months. Replace the switch 
            // statementwith code to convert monthNumber into 
            // the corresponding month name.

            Console.WriteLine("{0} {1}.", monthName, dayNumber);
        }

        // Do not change anything below this line
        static int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
