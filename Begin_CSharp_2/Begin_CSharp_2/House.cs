using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    internal class House
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Height { get; set; }
        public string RoofType { get; set; }
        public int Etagen { get; set; }
        public double Price { get; set; }
        public double PropertyLength { get; set; }
        public double PropertyWidth { get; set; }
        public double PropertyQM { get; set; }
        public double Wohnfläche { get; set; }
        public string Color { get; set; }

        public House(double length, double width, int height, string roofType, int etagen, double price, double propertyLength, double propertyWidth, double propertyQM, double wohnfläche, string color)
        {
            Length = length;
            Width = width;
            Height = height;
            RoofType = roofType;
            Etagen = etagen;
            Price = price;
            PropertyLength = propertyLength;
            PropertyWidth = propertyWidth;
            PropertyQM = propertyQM;
            Wohnfläche = wohnfläche;
            Color = color;
        }

        public House()
        {
        }

        public static House Property()
        {
            House qm = new House();

            Console.WriteLine("Wie lang ist das Haus?");
            qm.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit ist das Haus?");
            qm.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie hoch ist das Haus?");
            qm.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welche Dachart?");
            qm.RoofType = Console.ReadLine();

            Console.WriteLine("Wie viele Etagen?");
            qm.Etagen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preis?");
            qm.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie lang ist das Grundstück?");
            qm.PropertyLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit ist das Grundstück?");
            qm.PropertyWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Farbe soll das Haus haben?");
            qm.Color = Console.ReadLine();

            return qm;
        }

        public void CalculateProperties()
        {
            PropertyQM = PropertyLength * PropertyWidth;
            Wohnfläche = PropertyLength * PropertyWidth * Etagen;
        }

        public void ChangeHouseColor()
        {
            Console.WriteLine("Welche neue Farbe soll das Haus haben?");
            Color = Console.ReadLine();
        }

        public void PrintHouseInformation()
        {
            Console.WriteLine($"Das Haus ist {Length} Meter lang und {Width} Meter breit. Es hat ein {RoofType}dach und {Etagen} Etagen. Das ist Haus ist {Color}.");
            Console.WriteLine($"Das Grundstück ist {PropertyQM} qm groß, die Wohnfläche beträgt {Wohnfläche} qm.");
        }

        public void PrintNewHousInformation()
        {
            Console.WriteLine($"Die neue Hausfarbe ist {Color}");
            Console.ReadKey();
        }
    }
}
