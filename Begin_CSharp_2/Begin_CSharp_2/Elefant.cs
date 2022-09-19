using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Begin_CSharp_2
{
    public class Elefant : Tiere
    {
        public Elefant(string name, string species, int age, double height, int liefspan, double weight, bool furr, string noise)
        {
            Name = name;
            Species = species;
            Age = age;
            Height = height;
            Liefspan = liefspan;
            Weight = weight;
            Furr = furr;
            Noise = noise;
        }
    }
}
