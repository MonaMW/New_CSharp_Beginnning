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
            int zahl = Convert.ToInt32(Console.ReadLine());

            switch (zahl)
            {
                case 1:
                    Console.WriteLine("Die Zahl ist 1");
                    break;
                case 2:
                    Console.WriteLine("Die Zahl ist 2");
                    break;
                case 5:
                    Console.WriteLine("Die Zahl ist 5");
                    break;
                default:
                    Console.WriteLine("Kein Fall tritt ein");
                    break;
            }

            Console.ReadLine();
        }
    }
}
