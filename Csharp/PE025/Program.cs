using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 12;
            string Fn2 = "89";
            string Fn1 = "144";
            string Fn = string.Empty;

            while (Fn.Length != 1000)
            {
                Fn = Add(Fn1,Fn2);
                Fn2 = Fn1;
                Fn1 = Fn;
                n++;
            }

            Console.WriteLine("Fn = {0}", Fn);
            Console.WriteLine("n = {0}", n);
        }

        public static string Add(string a, string b)
        {
            string number1 = a;
            string number2 = b;
            if (a.Length < b.Length)
            {
                number1 = b;
                number2 = a;
            }

            int carry = 0;
            StringBuilder result = new StringBuilder();
            for (int i = number1.Length - 1, j = number2.Length - 1; i >= 0; i--, j--)
            {
                int sum = int.Parse(number1[i].ToString()) + carry;
                if (j >= 0) sum += int.Parse(number2[j].ToString());

                if (sum >= 10)
                {
                    carry = 1;
                    result.Append(sum.ToString()[1]);
                }
                else
                {
                    carry = 0;
                    result.Append(sum);
                }
            }
            if (carry == 1) result.Append(1);

            return ReverseNumber(result.ToString());
        }
        private static string ReverseNumber(string number)
        {
            StringBuilder result = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result.Append(number[i]);
            }
            return result.ToString();
        }
    }
}
