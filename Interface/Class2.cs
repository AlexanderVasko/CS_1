using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Class2
    {
        public void Method(IComparable obj1, IComparable obj2)
        {
            Console.WriteLine(obj1.CompareTo(obj2).ToString());
        }
    }
}

