using System;
using System.IO;
namespace DirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:Users\Admin\source\repos\SLot12_File\Demo\C#");
            Console.WriteLine("search pattern Demo* return: ");
            foreach (var fi in di.GetDirectories("Demo*"))
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine("Search Pattern TopDirectory returns: ");
            foreach(var fi in di.GetFiles("*.cs", SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
