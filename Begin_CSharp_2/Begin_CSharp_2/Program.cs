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
            int j = 0;

            for(int i = 0; i < entry; i++)
            {
                j = i + j;
                Console.WriteLine(j);
            }
            
            Console.ReadLine();
        }
    }
}
