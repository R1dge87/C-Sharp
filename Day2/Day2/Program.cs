using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 2: Operators
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            double tip = mealCost * ((double)tipPercent / 100);
            double tax = mealCost * ((double)taxPercent / 100);

            double totalCost = Math.Round(mealCost + tip + tax);

            Console.WriteLine("The total meal cost is " + totalCost + " dollars.");

            Console.ReadLine();
        }
    }
}
