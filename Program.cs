using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!!"); //huutomerkit

            //isot alkukirjaimet + !-merkki
            Console.WriteLine("Hello World!");

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

            //Improving Jyri's code by adding another cw
            Console.WriteLine("How u doin?");


            Console.WriteLine("Hei maailma!");

            Console.WriteLine("Hei maailma");

            File.WriteAllText("testitiedosto.txt", "Hello world");

            Console.WriteLine(@"  _____                ");
            Console.WriteLine(@" |_   _|__ _ ___ _____");
            Console.WriteLine(@"   | |/ -_) '_\ V / -_)");
            Console.WriteLine(@"   |_|\___|_|  \_/\___|");
          
            Console.ReadKey();
        }
    }
}
