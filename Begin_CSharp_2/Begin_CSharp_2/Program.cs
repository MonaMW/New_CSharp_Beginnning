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
            Random r = new Random();
            int random_zahl = r.Next(0, 100);
            int entry = 0;

            //man könnte auch eine bool Variable intitalisieren, auf false setzen
            //Variable wird true, wenn die eingegebene Zahl richtig ist
            //while(!BoolscheVariable)

            do
            {
                entry = Convert.ToInt32(Console.ReadLine());
                if (random_zahl > entry)
                    Console.WriteLine("Eingegebene Zahl ist kleiner");
                else if (random_zahl < entry)
                    Console.WriteLine("Eingegebene Zahl ist größer");
                else
                    Console.WriteLine("Eingegebene Zahl ist richtig");
            }
            while (random_zahl != entry);


            Console.ReadLine();
        }
    }
}
