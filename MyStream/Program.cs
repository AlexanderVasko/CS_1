using System;
using System.IO;

namespace MyStream
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stream myStream = new MemoryStream(new byte[] { 10, 20, 30, 100 });
            var Reader = new StreamReader(myStream);
            Reader.Peek();

        }
    }
}
