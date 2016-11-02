using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "2";
            int exponent = 1000;
            string result = Exponentiate(a, exponent);

            Console.WriteLine("{0}^{1} = {2}", a, exponent, result);

            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += int.Parse(result[i].ToString());
            }

            Console.WriteLine("sum of digits is {0}", sum);
        }

        private static string Exponentiate(string a, int exponent)
        {
            if (exponent == 0) return "1";
            string c = a;
            for (int i = 1; i < exponent; i++)
            {
                c = Multiply(c, a);
            }
            return c;
        }

        private static string Multiply(string a, string b)
        {
            string c = "0";
            for (string i = "0"; !i.Equals(b); i = Add(i, "1"))
            {
                c = Add(c, a);
            }
            return c;
        }

        private static string Add(string a, string b)
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
