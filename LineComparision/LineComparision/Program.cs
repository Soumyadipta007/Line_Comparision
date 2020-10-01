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
            Line l1 = new Line(x1,y1,x2,y2);
            Console.WriteLine("Enter the starting point x,y co-ordinates of the  2nd line");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending point x,y co-ordinates of the 2nd line");
            double x4 = Convert.ToInt32(Console.ReadLine());
            double y4 = Convert.ToInt32(Console.ReadLine());
            Line l2 = new Line(x3,y3,x4,y4);
            Console.WriteLine("Length of line 1: "+ l1.getLength());
            Console.WriteLine("Length of line 2: " + l2.getLength());
            if (l1.equals(l2))
            {
                Console.WriteLine("Lines are of equal Length");
            }
            else
            {
                Console.WriteLine("Lines are not of equal Length");
            }
            double difference = l1.getLength() - l2.getLength();
            int diff = l1.comparision(l2);
            if (diff > 0)
                Console.WriteLine("Length of line 1 is greater than line 2 by " + difference);
            else if (diff < 0)
                Console.WriteLine("Length of line 2 is greater than line 1 by " + Math.Abs(difference));
            else
                Console.WriteLine("Both lengths are equal ");
        }
    }
}
