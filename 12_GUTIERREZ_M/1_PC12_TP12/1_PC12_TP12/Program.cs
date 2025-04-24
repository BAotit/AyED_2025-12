using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP12
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;

            Console.WriteLine("Diga SI si desea cerrar el programa: ");
            respuesta = Console.ReadLine();

            while (respuesta != "SI")
            {
                Console.WriteLine("Diga SI si desea cerrar el programa: ");
                respuesta = Console.ReadLine(); 
            }

            Console.WriteLine("ADIOS ");

            Console.ReadKey();

        }
    }
}
