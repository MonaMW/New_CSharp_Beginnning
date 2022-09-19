using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public abstract class Vehicle       //abstract class, damit kein Objekt von der Klasse erstellt werden kann
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }


        public bool MotorLaeuft { get; private set; }  //kann nur von Methoden innerhalb Vehicle verändert werden
        public int Geschwindigkeit { get; private set; }

        public void Starten()
        {
            if(MotorLaeuft)
            {
                Console.WriteLine("Motor läuft schon, kann ihn nicht starten!");
            }
            else
            {
                MotorLaeuft = true;
                Console.WriteLine("Motor wird gestartet!");
            }
        }

        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }

        public void Bremsen()
        {
            if(Geschwindigkeit <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits.");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} wird gebremst.");
            }
            
        }
    }
}
