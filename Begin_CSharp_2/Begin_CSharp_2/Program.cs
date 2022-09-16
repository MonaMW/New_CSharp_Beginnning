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
            Console.WriteLine("Gib eine Zahl ein");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib eine weitere Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib einen Operator ein");
            string math_operator = Console.ReadLine();

            double addResult = Add(zahl1, zahl2);
            double minusResult = Minus(zahl1, zahl2);
            double multiResult = Multi(zahl1, zahl2);
            double divideResult = Divide(zahl1, zahl2);

            Console.WriteLine(addResult);
            Console.ReadLine();
        }

        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }

        static int Minus(int z1, int z2)
        {
            int summe = z1 - z2;
            return summe;
        }

        static int Multi(int z1, int z2)
        {
            int summe = z1 * z2;
            return summe;
        }

        static double Divide(int z1, int z2)
        {
            double summe = z1 / z2;
            return summe;
        }
    }
}
