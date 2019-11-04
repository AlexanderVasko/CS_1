using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            try
            {
                try
                {
                    int c = a / b;
                }
                catch (Exception e) when (e.Message.Length != 0)
                {
                    Console.WriteLine("dividing by zero");
                    Console.WriteLine(e.Message);
                    throw e;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch 2");
            }
            finally
            {

            }

            int k = 0x7FFFFFFF;

                int i = k + 100000;


            Console.WriteLine("Hello World!");
        }
    }
}
