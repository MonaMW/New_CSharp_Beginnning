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
            //Car c1 = new Car(13494, "Audi", "A3", "2.0 TDI", 1900, "rot", 4);
            //Car c2 = new Car(55543, "Volkswagen", "Golf 5", "GTI", 2000, "black", 4);

            //List<Car> cars = new List<Car>() { c1, c2 };    //Liste ist mit allen Infos gefüllt

            Console.WriteLine("Wie viele Autos sollen hinzugefügt werden?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for(int i = 0; i < anzahl; i++)
            {
                cars.Add(Car.AskUserForCar());
            }
            

            //Alle Fahrzeuge der Liste werden ausgegeben
            foreach (Car car in cars)
            {
                car.PrintCarInformation(); 
            }

            Console.ReadLine();
        }
    }
}
