using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public class Car
    {
        //Properties
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Typename { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }

        //Konstruktoren
        public Car(int typeId, string make, string model, string typeName, int cCM, string color, int tyres)    //Car erstellen und zurückgeben
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            Typename = typeName;
            CCM = cCM;
            Tyres = tyres;
            Color = color;
        }

        public Car()
        {
            //leerer Konstruktor für AskUserForCar. Man könnte die Werte auch in Variablen speichern in der Methode AskUserForCar
            //oder am Ende, vor return c; die Parameter(?) übergeben, wie in Program.cs
        }


        //Methoden
        //Car ist der Datentyp, der zurückgegeben wird. Könnte auch int oder string sein
        //static wird direkt auf Klasse aufgerufen, nicht auf Objekt
        public static Car AskUserForCar()
        {
            Car c = new Car();
            Console.WriteLine("Welche TypeId hat das Auto?");
            c.TypeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welche Marke hat das Auto?");
            c.Make = Console.ReadLine();

            Console.WriteLine("Welches Modell?");
            c.Model = Console.ReadLine();

            Console.WriteLine("Welchen Typnamen hat das Auto?");
            c.Typename = Console.ReadLine();

            Console.WriteLine("Wie viel CCM hat das Auto?");
            c.CCM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welche Farbe hat das Auto?");
            c.Color = Console.ReadLine();

            Console.WriteLine("Wie viele Reifen hat das Auto?");
            c.Tyres = Convert.ToInt32(Console.ReadLine());

            return c;
        }


        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein {Make} {Model} {Typename} mit einem Hubraum von {CCM} in der Farbe {Color} mit {Tyres} Reifen.");
        }
    }
}
