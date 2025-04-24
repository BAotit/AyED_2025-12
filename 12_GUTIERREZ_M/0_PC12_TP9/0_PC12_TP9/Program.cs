using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_TP9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Double radio, volumen, superficie;
            

            Console.WriteLine("introduce el radio de la esfera :");
            radio = int.Parse(Console.ReadLine());

            superficie = 4 * 3.14 * (radio * radio);
            volumen = (1.33 * 3.14 * (radio * radio * radio));

            Console.WriteLine("resultado superficie :" + superficie);
            Console.WriteLine("resultado volumen:" + volumen);
            Console.ReadKey();

        }
    }
}
