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
            Console.WriteLine("Bitte schreibe einen Text mit Leerzeichen am Anfang und Ende eingeben");
            string entry = Console.ReadLine();
            string trimmed_entry = entry.Trim();

            Console.WriteLine("Vorher:" + entry);
            Console.WriteLine("Nachher:" + trimmed_entry);

            Console.ReadLine();
        }
    }
}
