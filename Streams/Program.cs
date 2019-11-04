using System;
using System.IO;
using System.Text;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var c1251 = Encoding.GetEncoding(1251);

            var path = Environment.CurrentDirectory;
            var writeFile = File.Create($"{path}/Text.txt");
            var writer = new StreamWriter(writeFile, c1251);
            writer.WriteLine("Hello World!0");
            writer.WriteLine("Hello World!1");
            writer.WriteLine("кекеке");
            writer.WriteLine("Hello World!3");
            writer.WriteLine("Hello World!4");
            writer.Close();
            
            var readFile = File.OpenRead($"{path}/Text.txt");
            var reader = new StreamReader(readFile, c1251);

            for (; !reader.EndOfStream;)
            {
                Console.WriteLine(reader.ReadLine());
            }
            //
            var zipFile = File.Open($"{path}/Text.txt", FileMode.Append);

            var gZipS = new System.IO.Compression.GZipStream(zipFile, System.IO.Compression.CompressionMode.Compress);
        }
    }
}
