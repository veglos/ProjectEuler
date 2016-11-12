using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigNumbers bigNumbers = new BigNumbers();
            string factorial = "1";
            for(int i=1;i<=100;i++){
                factorial = bigNumbers.Multiply(factorial,i.ToString());
            }
            Console.WriteLine(factorial);
        }
    }
}
