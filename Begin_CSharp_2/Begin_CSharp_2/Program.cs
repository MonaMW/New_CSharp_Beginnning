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
            List<string> names = new List<string>();
            int entries = Convert.ToInt32(Console.ReadLine());
            string[] namenArray = new string[entries];
            Console.Clear();
            
            for(int i = 0; i < entries; i++)
            {
                names.Add(Console.ReadLine());
                namenArray[i] = i;
                Console.Clear();
            }

            //Einen Eintrag löschen
            names.RemoveAt(3);
            namenArray[3] = "";

            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }
}
