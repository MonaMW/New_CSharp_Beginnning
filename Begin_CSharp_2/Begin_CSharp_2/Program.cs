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
            Dreieck d = new Dreieck(2, 4, 10);

            Kreis c = new Kreis(5);

            Rechteck r = new Rechteck(10, 20);
 
            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);

            foreach(IGeometry g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} hat eine Fläche von {g.Flaeche()} und Umfang von {g.Umfang()}");
            }

            List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle(1445, "BMW", "GSXR 2000", "3.0", 3000, "Blau", 2));
            fahrzeuge.Add(new Car(123, "VW", "Golf V", "2.0 TDI", 1900, "Rot", 4));

            foreach(Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }

            Console.ReadLine();
        }
    }
}
