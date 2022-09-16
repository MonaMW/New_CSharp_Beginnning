using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array, das platz für fünf Werte hat
            string[] namen = new string[13];
            string[] namen2 = new string[] { "Lukas", "Jonas", "Mona", "Marie", "Philipp", "Jan", "Erwin", "Leon", "Marcello", "Johannes", "Robin", "Andreas", "Robert" };

            //for(int i = 0; i < namen.Length; i++)
            //{
            //    Console.WriteLine("Gebe mr einen Namen für das Array!");
            //    namen[i] = Console.ReadLine();
            //}

            for(int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
            //Console.WriteLine - schreibt immer in eine neue Zeile
            //Console.Write - schreibt alles in eine Zeile

            Console.ReadLine();
        }
    }
}
