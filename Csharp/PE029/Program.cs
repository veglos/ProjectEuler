using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApplication
{
    //WARNING: SLOW
    public class Program
    {
        public static void Main(string[] args)
        {

            List<string> sequence = new List<string>();

            for(int a=2;a<=100;a++){
                for(int b=2;b<=100;b++){
                    string result = a.ToString();
                    for(int i=1;i<b;i++){
                        result = Multiply(result,a.ToString());
                    }
                    if(!IsInSequence(result, sequence)) sequence.Add(result);
                }
            }

            Console.WriteLine(sequence.Count);
        }

        private static bool IsInSequence(string number, List<string> sequence){
            foreach(string sq in sequence){
                if(sq.Equals(number)) return true;
            }
            return false;
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
