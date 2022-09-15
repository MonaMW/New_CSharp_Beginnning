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
            Console.WriteLine("Bitte gebe einen Buchstaben ein");
            string entry = Console.ReadLine();

            List<string> list = new List<string>();
            list.Add("Marie");
            list.Add("Mona");
            list.Add("Marcello");
            list.Add("Lukas");
            list.Add("Philipp");
            list.Add("Robert");
            list.Add("Erwin");
            list.Add("Jonas");
            list.Add("Robin");
            list.Add("Leon");
            list.Add("Andreas");
            list.Add("Hannes");
            list.Add("Jan");

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(entry))
                    Console.WriteLine(list[i]);
            }


            Console.ReadLine();
        }
    }
}
