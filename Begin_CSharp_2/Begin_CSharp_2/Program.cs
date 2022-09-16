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
            //Aufgabe 2
            List<int> lst_numbers = new List<int>() { 5,3,7 };

            //Aufgabe 3
            while (true)
            {
                Console.WriteLine("Gib mir eine Zahl");
                string entry2 = Console.ReadLine();
                if (entry2 == String.Empty)
                    break;

                int entry = Convert.ToInt32(entry2);
                lst_numbers.Add(entry);
            }

            //Aufgabe 4
            for (int i = 0; i < lst_numbers.Count(); i++)
            {
                Console.WriteLine(lst_numbers[i]);
            }

            //Aufgabe 5
            //lst_numbers.RemoveAt(1);
            lst_numbers.Insert(1, 99);

            //Aufgabe 6
            List<int> lst_range = new List<int>() { 91, 92, 93 };
            lst_numbers.AddRange(lst_range);

            //Aufgabe 7
            lst_numbers.RemoveAt(0);

            //Aufgabe 8
            lst_numbers.Remove(99);

            //Aufgabe 9
            lst_numbers.RemoveAt(lst_numbers.Count - 1);

            //Aufgabe 10
            Console.WriteLine("Sorted list");
            lst_numbers.Sort();
            for(int i = 0; i < lst_numbers.Count(); i++)
            {
                Console.WriteLine(lst_numbers[i]);
            }

            Console.WriteLine("Reversed list");
            lst_numbers.Reverse();
            for(int i = 0; i < lst_numbers.Count(); i++)
            {
                Console.WriteLine(lst_numbers[i]);
            }

            //Aufgabe 11
            lst_numbers.RemoveAll(x => x > 80);
            
            
            Console.ReadLine();
        }
    }
}
