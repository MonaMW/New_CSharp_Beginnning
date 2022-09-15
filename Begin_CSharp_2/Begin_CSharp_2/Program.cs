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
            Console.WriteLine("Bitte schreibe einen Text mit ';' ein");
            string entry = Console.ReadLine();

            string[] split_entry = entry.Split(';');
            Console.WriteLine("Vorher:" + entry);

            for(int i = 0; i < split_entry.Length; i++)
            {
                Console.WriteLine("Split:" + split_entry[i]);
            }
            
            Console.ReadLine();
        }
    }
}
