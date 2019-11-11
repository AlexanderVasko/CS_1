using System;

namespace ExtendedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The Date is: ";
            Console.WriteLine(str);

            str = str.AddDateSignature();
            Console.WriteLine(str);

            uint value = 0xfffffff;
            Console.WriteLine(value);
            var temp = value.HiLo();
            //// Dynamic
            //Console.WriteLine($"Hi: {temp.Hi}");
            //Console.WriteLine($"Lo: {temp.Lo}");
            // Tuple
            Console.WriteLine($"Hi: {temp.Item1}");
            Console.WriteLine($"Lo: {temp.Item2}");            
        }
    }
}
