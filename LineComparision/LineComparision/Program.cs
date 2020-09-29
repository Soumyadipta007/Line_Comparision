using System;
using System.Numerics;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting point x,y co-ordinates of the  1st line");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending point x,y co-ordinates of the 1st line");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double len1 = getLength(x1, y1, x2, y2);
            Console.WriteLine("Enter the starting point x,y co-ordinates of the  2nd line");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending point x,y co-ordinates of the 2nd line");
            double x4 = Convert.ToInt32(Console.ReadLine());
            double y4 = Convert.ToInt32(Console.ReadLine());
            double len2 = getLength(x3, y3, x4, y4);
            double difference = Math.Abs(len1 - len2);
            int diff = len1.CompareTo(len2);
            if (diff > 0)
                Console.WriteLine("Length of line 1 is greater than line 2 by " + difference);
            else if (diff < 0)
                Console.WriteLine("Length of line 2 is greater than line 1 by " + difference);
            else
                Console.WriteLine("Both lengths are equal ");
        }
        public static double getLength(double x1, double y1, double x2, double y2)
        {
            double diffX = x2 - x1;
            double diffY = y2 - y1;
            double lengthOfLine = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return lengthOfLine;
        }
    }
}
