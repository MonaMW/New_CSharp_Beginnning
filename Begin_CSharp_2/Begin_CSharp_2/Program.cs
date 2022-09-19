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
            Console.WriteLine("Wie viele Häuser sollen hinzugefügt werden?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            List<House> houses = new List<House>();
            
            
            for (int i = 0; i < anzahl; i++)
            {
                houses.Add(House.Property());
            }


            foreach (House house in houses)
            {
                house.CalculateProperties();
                house.PrintHouseInformation();
            }

            Console.ReadLine();
        }
    }
}
