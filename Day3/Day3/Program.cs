using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro into conditional statements
            int n = Convert.ToInt32(Console.ReadLine());

            if (n%2 > 0)
            {
                Console.WriteLine("Weird");
            }
            else if (n%2 == 0)
            {
                if (n >= 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (n >= 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }

            Console.ReadLine();
        }
    }
}
