using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                count += CountLettersInNumberName(GetNumberName(i));
            }

            Console.WriteLine(count);
        }

        private static int CountLettersInNumberName(string number){
            int count = 0;
            for(int i=0;i<number.Length;i++){
                if(!char.IsWhiteSpace(number[i]) && number[i] != '-') count++;
            }
            return count;
        }

        private static string GetNumberName(int number)
        {
            string[] a = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] b = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] c = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 10) return a[number - 1];

            if (9 < number && number < 20) return b[number - 10];

            if (19 < number && number < 100)
            {
                int tens = int.Parse(number.ToString()[0].ToString());
                int unit = (number - tens * 10 > 0) ? number - tens * 10 : 0;
                if (unit == 0) return c[tens - 2];
                return c[tens - 2] + "-" + a[unit - 1];
            }

            if(99 < number && number < 1000){
                int hundreds = int.Parse(number.ToString()[0].ToString());
                int tens = (number - hundreds * 100 > 0) ? number - hundreds * 100 : 0;
                if(tens == 0) return a[hundreds-1] + " hundred";
                return a[hundreds-1] + " hundred and " + GetNumberName(tens);
            }

            if(number == 1000) return "one thousand";

            return "unknown";
        }
    }
}
