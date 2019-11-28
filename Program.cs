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
            Console.WriteLine("Hello world");
            Console.WriteLine("Hei maailma");
            File.WriteAllText("testitiedosto.txt", "Hello world");1
        }
    }
}
