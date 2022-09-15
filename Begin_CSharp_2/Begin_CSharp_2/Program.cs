using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte schreibe einen Text mit mindestens 21 Zeichen");
            string entry = Console.ReadLine();
            int length = entry.Length + 30;
            string padded_entry = entry.PadLeft(length, 'y');

            Console.WriteLine("Vorher:" + entry);
            Console.WriteLine("Nachher:" + padded_entry);

            Console.ReadLine();
        }
    }
}
