using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static string filename = "names.txt";
        public static void Main(string[] args)
        {
            //read file to string array
            //sort names
            //for each name get score. Acumulate scores
            //print total score
            string[] names = GetNames(filename);
            int totalScore = GetTotalScore(names);
            Console.WriteLine(totalScore);
        }

        private static int GetTotalScore(string[] names){
            int totalScore = 0;
            for(int i=names.Length - 1; i>=0;i--){
                totalScore += GetNameWorth(names[i]) * (i + 1);    
            }
            return totalScore;
        }

        private static int GetNameWorth(string name)
        {
            int worth = 0;
            foreach (char c in name)
            {
                worth += c - 64;
            }
            return worth;
        }

        private static string[] GetNames(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            System.IO.StreamReader file = new System.IO.StreamReader(fs);

            List<string> names = new List<string>();

            string line = string.Empty;
            while ((line = file.ReadLine()) != null)
            {
                foreach (string name in line.Split(','))
                {
                     names.Add(name.Trim('"'));
                }
            }

            names.Sort();
            return names.ToArray();
        }
    }
}
