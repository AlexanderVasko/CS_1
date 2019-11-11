using Library;
using System;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel newWheel = Wheel.CreateWheel(WheelSize.d10, 4);
        }
    }
}