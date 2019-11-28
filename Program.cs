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

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Hei Jyri");
            }

           

            Console.WriteLine("Hello world");

             Console.WriteLine("Hei maailma!");



            File.WriteAllText("testitiedosto.txt", "Hello world");

        }
    }
}
