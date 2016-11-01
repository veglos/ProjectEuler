using System;
using System.Text;

namespace ConsoleApplication
{
    /*
    Problem: 2^15 = 32768 and the sum of its digits is 3+2+7+6+8 =26
    What is the sum of the digits of the number 2^1000?
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "2";
            string b = "2";            

            int power = 5;

            string c = a;
            for(int i=0;i<power;i++){
                c = Multiply(c,b);
            }

            Console.WriteLine(c);
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

        private static string Add(string number1, string number2)
        {
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
