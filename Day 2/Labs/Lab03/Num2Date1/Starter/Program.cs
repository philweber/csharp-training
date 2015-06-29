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
            // Prompt user for a number between 1 and 365
            // Store number in integer variable
            
            // Calculate which month day number is in
            int monthNumber = 1;

            if (dayNumber <= 31)    // January
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 28)    // February
            {
                goto End;
            }
            else
            {
                dayNumber -= 28;
                monthNumber++;
            }

            if (dayNumber <= 31)    // March
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 30)    // April
            {
                goto End;
            }
            else
            {
                dayNumber -= 30;
                monthNumber++;
            }

            if (dayNumber <= 31)    // May
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 30)    // June
            {
                goto End;
            }
            else
            {
                dayNumber -= 30;
                monthNumber++;
            }

            if (dayNumber <= 31)    // July
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 31)    // August
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 30)    // September
            {
                goto End;
            }
            else
            {
                dayNumber -= 30;
                monthNumber++;
            }

            if (dayNumber <= 31)    // October
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }

            if (dayNumber <= 30)    // November
            {
                goto End;
            }
            else
            {
                dayNumber -= 30;
                monthNumber++;
            }

            if (dayNumber <= 31)    // December
            {
                goto End;
            }
            else
            {
                dayNumber -= 31;
                monthNumber++;
            }
        
        End:

            // Convert month number to month name
            // Display result
        }
    }
}
