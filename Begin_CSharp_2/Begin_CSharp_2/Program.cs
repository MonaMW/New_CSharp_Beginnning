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
            Console.WriteLine("Wie viele Einträge soll das Array haben?");
            int count = Convert.ToInt32(Console.ReadLine());
            float[] ints = new float[count];
            float for_loop = 0;
            float foreach_loop = 0;

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < ints.Length; i++)
            {
                for_loop += ints[i];
            }

            foreach(int i in ints) 
            {
                foreach_loop += ints[i];
            }


            Console.ReadLine();
        }
    }
}
