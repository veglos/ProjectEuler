using System;

namespace ConsoleApplication
{
    public class Program
    {

        private enum Day { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun };
        private enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        private static int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static string[] NameOfMonth = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private static string[] NameOfDay = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public static void Main(string[] args)
        {
            int dayNumber = 1;
            int currentDay = (int)Day.Tue;
            int currentMonth = (int)Month.Jan;
            int totalSundays = 0;

            for (int year = 1901; year <= 2000; year++)
            {
                int totalDays = IsLeapYear(year) ? 366 : 365;
                for (int i = 1; i <= totalDays; i++)
                {
                    if (currentDay > (int)Day.Sun) currentDay = (int)Day.Mon;
                    if (currentMonth > (int)Month.Dec) currentMonth = (int)Month.Jan;

                    int leapDay = (currentMonth == (int)Month.Feb && IsLeapYear(year)) ? 1 : 0;

                    if (dayNumber > DaysInMonth[currentMonth] + leapDay)
                    {
                        dayNumber = 1;
                        currentMonth++;
                    }

                    //Console.WriteLine("{0} {1}/{2}/{3}", NameOfDay[currentDay - 1], dayNumber, NameOfMonth[currentMonth], year);
                    if (dayNumber == 1 && currentDay == (int)Day.Sun) totalSundays++;

                    currentDay++;
                    dayNumber++;
                }
            }

            Console.Write("Sundays: {0}", totalSundays);
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 || year == 2000);
        }


    }
}
