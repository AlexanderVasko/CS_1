using System;

namespace Delegate
{
    class Program
    {
        public delegate int Foo();

        public static event Foo SomeEvent;
        static int SomeFoo1()
        {
            Console.WriteLine("foo1");
            return 0;
        }        
        static int SomeFoo2()
        {
            Console.WriteLine("foo2");
            return 1;
        }

        static void Main(string[] args)
        {
            var class1 = new DelegateClass();

            class1.fooEvent += SomeFoo1;
            class1.fooEvent += SomeFoo2;
            
            Foo ptrFoo = SomeFoo1;
            ptrFoo += SomeFoo2;
            
            Console.WriteLine(ptrFoo());
        }
    }
}
