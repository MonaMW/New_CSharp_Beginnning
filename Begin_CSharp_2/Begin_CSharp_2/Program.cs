using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gib eine andere Zahl ein");            
            int second_number = Convert.ToInt32(Console.ReadLine());

            int sum = first_number + second_number;

            Console.WriteLine("Summe: " + sum);
            Console.ReadLine();
        }
    }
}
