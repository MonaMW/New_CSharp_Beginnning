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

            string to_upper_case = entry.ToUpper();
            string to_lower_case = entry.ToLower();

            Console.WriteLine("Upper Cases: " + to_upper_case);
            Console.WriteLine("Lower Cases: " + to_lower_case);
            
            Console.ReadLine();
        }
    }
}
