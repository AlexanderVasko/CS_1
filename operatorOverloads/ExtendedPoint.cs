using System;
using System.Collections.Generic;
using System.Text;

namespace operatorOverloads
{
    static class ExtendedPoint
    {
        public static Point CreatePoint(this double a)
        {
            return new Point() { x = a, y = a };
        }
    }
}
