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

            #region Calculate month and day
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
        
            #endregion        

        End:

            string monthName = "";

            switch (monthNumber)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                default:
                    monthName = "December";
                    break;
            }

            Console.WriteLine("{0} {1}.", monthName, dayNumber);
        }
    }
}
