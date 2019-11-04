using System;
using System.Collections.Generic;
using System.Text;

namespace operatorOverloads
{
    public struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "point X: Y:" + x.ToString() + y.ToString();
        }

        public static explicit operator Point(double a)
        {
            return new Point() { x = a, y = a };
        }
    }
}
