using System;
using System.IO;

namespace StreamWriterAndReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string path = @"MyFile.txt";
            Console.WriteLine("Demo stream writer and reader ");
            using StreamWriter sr = new StreamWriter(path);
            sr.WriteLine("hello");
            sr.WriteLine("and");
            sr.WriteLine("wellcome");
            for (int i = 0; i < 10; i++)
            {
                sr.Write(i + " ");
            }
            Console.WriteLine("FILE CREATED ");
        }
    }
}
