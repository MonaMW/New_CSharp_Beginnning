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
            //Interface wird nur zum Vererben von Methoden verwendet

            List<Tiere> animals = new List<Tiere>();
            animals.Add(new Elefant("Benjamin", "Elefant", 10, 5, 30, 2000, false, "Trööt"));
            animals.Add(new Giraffe("Gigi", "Giraffe", 5, 10, 15, 500, true, "Schmatz"));
            animals.Add(new Tiger("Tina", "Tiger", 2, 1, 30, 300, true, "Roar"));
            animals.Add(new Pinguin("Pino", "Pinguin", 3, 0.5, 25, 20, true, "Quietschen"));

            foreach (Tiere t in animals)
            {
                t.Geraeusche();
                t.Essen();
                t.Geraeusche();
                t.Trinken();
                t.Geraeusche();
                t.PrintInfo();
            }

            Console.ReadLine();
        }
    }
}
