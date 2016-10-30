using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long finalSum = 1000;
            long product = 0;
            bool tripletFound = false;

            long x,y,z;
            x = y = z = 0;

            for(long c=finalSum;c>0;c--){
                if(tripletFound) break;
                for(long b=c-1;b>0;b--){
                    if(tripletFound) break;
                    for(long a=b-1;a>0;a--){
                        if(a+b+c == finalSum && a*a + b*b == c*c){
                            tripletFound = true;
                            product = a*b*c;
                            x = a;
                            y = b;
                            z = c;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("The product of {0} x {1} x {2} is {3}", x,y,z,product);
        }
    }
}
