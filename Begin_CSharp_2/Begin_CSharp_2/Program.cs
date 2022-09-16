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
            int[] zahlen = new int[5];
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6 };

            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mr eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("[");
            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($" {zahlen[i]} | ");
            }
            Console.Write(" ]");
            //Console.WriteLine - schreibt immer in eine neue Zeile
            //Console.Write - schreibt alles in eine Zeile

            Console.ReadLine();
        }
    }
}
