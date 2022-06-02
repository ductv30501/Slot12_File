using System;
using System.IO;

namespace DirectoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                var txtFile = Directory.EnumerateFiles(sourceDirectory, "*.*");
                foreach(string currenFile in txtFile)
                {
                    Console.WriteLine(currenFile);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
