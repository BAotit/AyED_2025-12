using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int celcius;

            Console.WriteLine("ingrese la temperatura en celcius");

            celcius = int.Parse(Console.ReadLine());

            if (celcius <= 0)
            {
                Console.WriteLine("se congela");
            }
            else if (celcius >= 100)
            {
                Console.WriteLine("hierve");
            }
            else if ((celcius >= 1) && (celcius <= 99))
            {
                Console.WriteLine("esta en estado liquido");
            }

            Console.ReadKey();




        }
    }
}
