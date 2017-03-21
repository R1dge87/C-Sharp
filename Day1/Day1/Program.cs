using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1: Data Types
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int j = int.Parse(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            string t = Console.ReadLine();

            Console.WriteLine(i + j);
            Console.WriteLine((d + f).ToString("F1"));
            Console.WriteLine(s + t);

            Console.ReadLine();
        }
    }
}
