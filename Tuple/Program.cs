using System;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static Tuple<string, int, double> Foo(int i, string s, double d)
        {
            return new Tuple<string, int, double>(s, i, d);
        }

        static void Foo()
        {
            Console.WriteLine("Foo");
        }

        static void Main(string[] args)
        {
            //var a = Foo(10, "Hello World", 3.12);            
            //Console.WriteLine(a);
            Action action = new Action(Foo);
            Task task = new Task(action);
            task.Start();
        }
    }
}
