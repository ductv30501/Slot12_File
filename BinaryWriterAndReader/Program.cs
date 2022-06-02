using System;
using System.IO;
namespace BinaryWriterAndReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            Console.WriteLine("Demo Binary Writer And reader");
            FileInfo f = new FileInfo(path);
            using BinaryWriter bw = new BinaryWriter(f.OpenWrite());
            Console.WriteLine("base stream is :{0}", bw.BaseStream);
            double a = 918.99;
            int b = 9999;
            string s = " A,B, C";
            bw.Write(a);
            bw.Write(b);
            bw.Write(s);
            bw.Close();
            Console.WriteLine("file created");
            Console.WriteLine("read: ");
            using BinaryReader br = new BinaryReader(f.OpenRead());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
        }
    }
}
