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
          
            if (!File.Exists(filename)) //Hyvähyvä!
            {
                File.WriteAllText(filename, "Eka rivi\n");
            }

            File.AppendAllText(filename, "Seuraava rivi¨\n");

            for (int i = 0; i < 50; i++) //miksi juuri 50? Pitäisikö käyttää jotain muuttujaa?
            {
                Console.WriteLine("Hei Jyri");
            }

            Console.WriteLine("Hello world");

            Console.WriteLine("Hei maailma!");

            Console.WriteLine("Hei maailma");

            File.WriteAllText("testitiedosto.txt", "Hello world");
        }
    }
}
