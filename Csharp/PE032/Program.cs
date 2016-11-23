using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> products = new List<int>();

            for (int i = 1; i <= 9999; i++)
            {
                for (int j = 1; j <= 9999; j++)
                {
                    int k = i * j;
                    string identity = i.ToString() + j.ToString() + k.ToString();
                    if (identity.Length != 9) continue;
                    if (IsPandigital(identity))
                    {
                        Console.WriteLine(i.ToString() + " " + j.ToString() + " " + k.ToString());
                        products.Add(k);
                    }
                }
            }

            products = RemoveDuplicates(products);
            int sum = 0;
            foreach (int p in products)
            {
                sum += p;
            }
            Console.WriteLine(sum);
        }


        private static List<int> RemoveDuplicates(List<int> list)
        {
            List<int> cleanList = new List<int>();
            foreach (int n in list)
            {
                if (!IsInList(cleanList, n)) cleanList.Add(n);
            }
            return cleanList;
        }

        private static bool IsPandigital(string number)
        {
            List<int> digits = new List<int>();
            int largest = 0;
            int sum = 0;
            foreach (char n in number)
            {
                if(n.Equals('0')) return false;

                int d = int.Parse(n.ToString());

                if (!IsInList(digits, d))
                {
                    digits.Add(d);
                }
                else
                {
                    return false;
                }

                sum += d;
                if (d > largest) largest = d;
            }

            if (sum == SumOfFirstN(largest)) return true;

            return false;
        }

        private static bool IsInList(List<int> digits, int number)
        {
            foreach (int d in digits)
            {
                if (number == d) return true;
            }
            return false;
        }

        private static int SumOfFirstN(int n)
        {
            return (n * (n + 1)) / 2;
        }
    }
}
