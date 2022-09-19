using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public class Car
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Typename { get; set; }
        public int CCM { get; set; }
        public int Tyres { get; set; }
        public string Color { get; set; }

        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein {Make} {Model} {Typename} mit einem Hubraum von {CCM} in der Farbe {Color} mit {Tyres} Reifen.");
        }
    }
}
