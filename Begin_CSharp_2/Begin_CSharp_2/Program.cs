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
            Console.WriteLine("Bitte gib eine Kommazahl ein");
            double first_number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte gib eine andere Kommazahl ein");
            double second_number = Convert.ToDouble(Console.ReadLine());

            double sum = first_number + second_number;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
