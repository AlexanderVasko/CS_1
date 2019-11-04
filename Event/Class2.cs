using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Class2
    {
        public delegate void Foo();

        public static void SomeFoo1()
        {
            Console.WriteLine("Foo1");
            return;
        }
    }
}
