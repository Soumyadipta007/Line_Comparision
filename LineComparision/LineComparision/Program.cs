using System;
using System.Numerics;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            Console.WriteLine("Enter the starting point x,y co-ordinates of the line");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending point x,y co-ordinates of the line");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double diffX = x2 - x1;
            double diffY = y2 - y1;
            double lengthOfLine = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            Console.WriteLine("Length of Line: " + lengthOfLine);
        }
    }
}
