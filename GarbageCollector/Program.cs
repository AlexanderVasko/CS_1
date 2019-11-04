using System;
using System.Threading;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {            
            Thread.Sleep(5000);
            Console.WriteLine(GC.GetTotalMemory(true));
        }
    }
}
