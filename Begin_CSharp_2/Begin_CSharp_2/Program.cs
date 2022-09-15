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
            Console.WriteLine("Wie viele Einträge möchtest du in deinem Array?");
            int entries_count = Convert.ToInt32(Console.ReadLine());

            int[] entry_array = new int[entries_count];

            for(int i = 0; i < entries_count; i++)
            {
                Console.WriteLine("Welche Zahl soll eingetragen werden?");
                entry_array[i] = Convert.ToInt32(Console.ReadLine());              
            }
            
            for(int i = 0; i < entry_array.Count(); i++)
            {
                Console.WriteLine(entry_array[i]);
            }

            Console.ReadLine();
        }
    }
}
