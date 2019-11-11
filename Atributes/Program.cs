using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Days.Saturday;
            Console.WriteLine(a.Description());
        }
    }
}
