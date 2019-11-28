using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"tiedosto.txt";

            Console.WriteLine("Hello world");
            if (!File.Exists(filename))
                File.WriteAllText(filename, "Eka rivi\n");


            File.AppendAllText(filename, "Seuraava rivi¨\n");
        }
    }
}
