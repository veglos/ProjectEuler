using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigNumbers bigNumbers = new BigNumbers();
            int factorial = 100;
            string result = "1";
            for(int i=1;i<=factorial;i++){
                result = bigNumbers.Multiply(result,i.ToString());
            }
            Console.WriteLine(result);
            int sum = AddDigits(result);
            Console.WriteLine(sum);
        }

        private static int AddDigits(string number){
            int sum = 0;
            foreach(char c in number){
                sum += int.Parse(c.ToString());
            }
            return sum;
        }
    }
}
