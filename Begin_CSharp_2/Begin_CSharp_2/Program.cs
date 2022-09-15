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
            Console.WriteLine("Bitte schreibe einen Text ein");
            string entry = Console.ReadLine();

            if (entry.Contains("abc"))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            
            Console.ReadLine();
        }
    }
}
