using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_TP12
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra1, letra2, letra3;


            Console.WriteLine("introduce 3 letras:");

            letra1 = (Console.ReadLine());
            letra2 = (Console.ReadLine());
            letra3 = (Console.ReadLine());


            Console.WriteLine(letra3+
                letra2
                + letra1);
          
            Console.ReadKey();
        }
    }
}
