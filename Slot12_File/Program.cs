using System;
using System.IO;
using System.Text;

namespace Slot12_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fstream = File.Open("Myfile.dat", FileMode.Create);
            string mes = "demo file";
            byte[] mesASbyteArray = Encoding.Default.GetBytes(mes);
            fstream.Write(mesASbyteArray, 0, mesASbyteArray.Length);
            fstream.Position = 0 ;
            Console.WriteLine(" print message as an array of byte: ");
            byte[] bytesfromfile = new byte[mesASbyteArray.Length];
            for(int i = 0; i< mesASbyteArray.Length; i++)
            {
                bytesfromfile[i] = (byte)fstream.ReadByte();
                Console.WriteLine($"{bytesfromfile[i],5}");
            }
            Console.WriteLine("\n Demo message");
            Console.WriteLine(Encoding.Default.GetString(bytesfromfile));
            Console.ReadLine();
        }
    }
}
