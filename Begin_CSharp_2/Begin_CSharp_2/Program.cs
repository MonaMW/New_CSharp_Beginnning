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
            int budget = 10000;
            Console.WriteLine("Budget ist " + budget);

            Console.WriteLine("Setze deinen Einsatz");
            int einsatz = Convert.ToInt32(Console.ReadLine());

            bool gewonnen = true;
            
            Random k = new Random();
            int random_zahl;

            int count = 0;

            do
            {
                random_zahl = k.Next(0, 36);

                if (budget >= 10000 && gewonnen)
                {
                    einsatz += 10;
                    Console.WriteLine("Einsatz 10$");
                    budget = budget - einsatz;
                }
                else if (budget >= 10000 && !gewonnen)
                {
                    einsatz += 20;
                    Console.WriteLine("Einsatz 20$");
                    budget = budget - einsatz;
                }

                //Gesamtverlust wird verdoppelt
                if (budget < 10000)
                {
                    einsatz = (10000 - budget) * 2;
                }

                //Budget reicht nicht für geplanten Zug
                if (einsatz > budget)
                    einsatz = budget;

                //wenn k gerade und größer 0
                if (random_zahl > 0 && random_zahl % 2 == 0)
                {
                    gewonnen = true;
                    budget += einsatz * 2;
                    Console.WriteLine("Sie erhalten " + einsatz * 2);
                }
                //wenn k == 0
                else if (random_zahl == 0)
                {
                    Console.WriteLine("Ihr Einsatz bleibt bestehen.");
                }
                //wenn k ungerade ist
                else if (!(random_zahl % 2 == 0))
                {
                    budget = budget - einsatz;
                    Console.WriteLine("Sie haben Ihren Einsatz verloren.");
                    gewonnen = false;
                }
                count++;

            } while (budget > 0 && gewonnen);

            Console.WriteLine("Anzahl Spiele: " + count);
            Console.ReadLine();
        }
    }
}
