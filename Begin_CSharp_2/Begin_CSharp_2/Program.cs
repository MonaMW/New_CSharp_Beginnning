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
            Console.WriteLine("Bitte gebe eine Zahl ein");
            int entry = Convert.ToInt32(Console.ReadLine());

            for(int i = entry; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
