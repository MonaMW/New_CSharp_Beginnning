using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public abstract class Tiere
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Liefspan { get; set; }
        public double Weight  { get; set; }
        public bool Furr { get; set; }
        public string Noise { get; set; }

        public void Essen()
        {
            Console.WriteLine($"{this.Name} isst.");
        }

        public void Trinken()
        {
            Console.WriteLine($"{this.Name} trinkt.");
        }

        public void Geraeusche()
        {
            Console.WriteLine($"{this.Name} macht {Noise}.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{this.Name} ist {this.Age} Jahre alt und {this.Height} groß. Die Lebensspanne beträgt {this.Liefspan} Jahre, das Gewicht {this.Weight} kg. {this.Name} ist ein {this.Species}.");
            Console.WriteLine("");
        }
    }
}
