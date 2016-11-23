using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ways = 0;
            //1 2 5 10 20 50 100 200
            for (int a = 0; a <= 200; a++)
            {
                for (int b = 0; b <= 200; b += 2)
                {
                    for (int c = 0; c <= 200; c += 5)
                    {
                        for (int d = 0; d <= 200; d += 10)
                        {
                            for (int e = 0; e <= 200; e += 20)
                            {
                                for (int f = 0; f <= 200; f += 50)
                                {
                                    for (int g = 0; g <= 200; g += 100)
                                    {
                                        for (int h = 0; h <= 200; h += 200)
                                        {
                                            if(a+b+c+d+e+f+g+h == 200) ways++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ways);
        }
    }
}
