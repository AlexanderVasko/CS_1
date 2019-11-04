using System;
using System.Numerics;

namespace Struct_int128
{
    class Program
    {
        static void Main(string[] args)
        {
            long someInt1 = 8000000000000000001;
            long someInt2 = 8999999999999999999;

            Int128 I1_128 = new Int128(someInt1);
            Int128 I2_128 = new Int128(someInt2);

            Int128 I3_128 = I1_128 + I2_128;

            Console.WriteLine(I1_128.ToString() + " + " + I2_128.ToString() + " = " + I3_128.ToString());
            BigInteger newint = long.MaxValue;
            newint += newint;

            Span<int> a = stackalloc[] { 1, 2, 3, 4 };

            var bflag = eByteFlags.second;
            if (bflag.HasFlag(eByteFlags.second))
            {
                Console.WriteLine("it has");
            }
            else
            {
                Console.WriteLine("it has not" + bflag.ToString());
            }
        }
    }
}
