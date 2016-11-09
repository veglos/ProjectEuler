using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {  
            
        }


        private static int GetDaysBetweenYears(int firstyear, int lastyear)
        {
            int days = 0;

            for (int i = firstyear; i <= lastyear; i++)
            {
                days += (IsLeapYear(i)) ? 366 : 365;
            }

            return days;
        }

        private static bool IsLeapYear(int year)
        {
            return !(year % 4 == 0 && year != 2000);
        }


    }
}
