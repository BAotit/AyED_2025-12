using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("ingrese una palabra");
            palabra = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1)+palabra);
            }

            Console.ReadKey();
        }
    }
}
