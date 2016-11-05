using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static string filename = "triangle.txt";

        public static void Main(string[] args)
        {
            int[][] triangle = GetTriangle(filename);
            int sum = 0;
            int position = 0;

            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                sum += GetNextNumber(position, triangle[i]);
                position = GetNewPosition(position, triangle[i]);
            }

            Console.WriteLine(sum);
        }

        private static int[][] GetTriangle(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            System.IO.StreamReader file = new System.IO.StreamReader(fs);
            string line = string.Empty;

            List<int[]> triangle = new List<int[]>();
            while ((line = file.ReadLine()) != null)
            {
                string[] a = line.Split(' ');
                List<int> numbers = new List<int>();
                foreach (string s in a)
                {
                    numbers.Add(int.Parse(s));
                }
                triangle.Add(numbers.ToArray());
            }

            return triangle.ToArray();
        }

        private static int GetNewPosition(int lastposition, int[] line)
        {
            if (lastposition + 1 >= line.Length)
            {
                return lastposition;
            }
            int a = line[lastposition];
            int b = line[lastposition + 1];
            return (a > b) ? lastposition : ++lastposition;
        }

        private static int GetNextNumber(int position, int[] line)
        {
            if (position + 1 >= line.Length)
            {
                return line[position];
            }
            int a = line[position];
            int b = line[position + 1];
            return (a > b) ? a : b;
        }
    }
}
