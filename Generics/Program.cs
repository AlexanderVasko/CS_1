using System;

namespace Generics
{
    class Program
    {
        static int Foo1()
        {
            return 2;
        }
        static void Main(string[] args)
        {
            //Class1<int> obj1 = new Class1<int>
            //{
            //    _var1 = 20
            //};
            //Console.WriteLine(obj1.GetTest());

            Class1<string> obj2 = new Class1<string>
            {
                _var1 = "string"
            };
            Console.WriteLine(obj2.GetTest());

            Console.WriteLine(Class1<Object>.GetString(10));

            GenericDelegate<int> obj3 = new GenericDelegate<int>();

            obj3._delegate1 += Foo1;
            
        }
    }
}
