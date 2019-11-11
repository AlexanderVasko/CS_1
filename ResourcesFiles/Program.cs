using System;

namespace ResourcesFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resource1.Hello);
            Console.WriteLine(Resource1.kuku);

            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.ToString());
        }
    }
}
