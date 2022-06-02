using System;
using System.IO;

namespace DemoFileClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            if (!File.Exists(path))
            {
                string createText = "Hello World" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string append = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, append);
            string s = File.ReadAllText(path);
            Console.WriteLine(s);
        }
    }
}
