using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            IComparable Iobj1 = obj1;

            Class2 obj2 = new Class2();

            obj2.Method(obj1, Iobj1);
        }
    }
}
