using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class Line
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;
        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double getLength()
        {
            double diffX = x2 - x1;
            double diffY = y2 - y1;
            double lengthOfLine = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return lengthOfLine;
        }
        public bool equals(Line l2)
        {
            return (this.getLength()).Equals(l2.getLength());
        }
        public int comparision(Line l2)
        {
            return (this.getLength()).CompareTo(l2.getLength());
        }
    }
}
