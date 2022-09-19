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
            Car c1 = new Car();
            c1.TypeId = 13494;
            c1.Make = "Audi";
            c1.Model = "A3";
            c1.Typename = "2.0 TDI";
            c1.CCM = 1900;
            c1.Tyres = 4;
            c1.Color = "rot";

            //c1.PrintCarInformation();

            Car c2 = new Car();
            c2.TypeId = 55543;
            c2.Make = "Volkswagen";
            c2.Model = "Golf 5";
            c2.Typename = "GTI";
            c2.CCM = 2000;
            c2.Tyres = 4;
            c2.Color = "black";

            //c2.PrintCarInformation();

            //Console.WriteLine($"Mein Fahrzeug ist ein {c1.Make} {c1.Model} {c1.Typename} mit einem Hubraum von {c1.CCM} in der Farbe {c1.Color} mit {c1.Tyres} Reifen.");
            Console.ReadLine();
        }
    }
}
