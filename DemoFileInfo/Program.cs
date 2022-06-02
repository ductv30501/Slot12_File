using System;
using System.IO;

namespace DemoFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            File.WriteAllText(path, "Hello");
            Console.WriteLine("read file: ");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            Console.WriteLine("read file information: ");
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($"name: {fileInfo.Name}");
            Console.WriteLine($"creation time : {fileInfo.CreationTime}");
            Console.WriteLine($"last write time : {fileInfo.LastWriteTime}");
            Console.WriteLine($"diractory name : {fileInfo.DirectoryName}");
        }
    }
}
