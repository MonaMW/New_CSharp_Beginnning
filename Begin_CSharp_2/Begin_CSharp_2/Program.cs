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

            Console.WriteLine("Gib einen Operator ein");
            string math_operator = Console.ReadLine();

            Console.WriteLine("Gib eine weiter Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            double ergebnis = 0;

            switch (math_operator)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "-":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    break;
                default:
                    break;
            }


            Console.WriteLine("Die Zahl ist: " + ergebnis);

            Console.ReadLine();
        }
    }
}
