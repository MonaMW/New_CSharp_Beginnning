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
            Console.WriteLine("Bitte gib einen Text ein");
            string entry = Console.ReadLine();

            string replace_entry = entry.Replace("U", "u").Replace("G", "g");

            Console.WriteLine("Vorher: " + entry);
            Console.WriteLine("Nachher: " + replace_entry);
            Console.ReadLine();
        }
    }
}
