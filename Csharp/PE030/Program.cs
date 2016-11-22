using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            for(int i=2;i<=9999999;i++){
                string number = i.ToString();
                int sum = 0;
                foreach(char c in number){
                    int n = int.Parse(c.ToString());
                    sum += n*n*n*n*n;
                }
                if(sum == i){
                    Console.WriteLine(sum);
                    result += sum;
                }
            }
            Console.WriteLine("result = {0}",result);
        }
    }
}
