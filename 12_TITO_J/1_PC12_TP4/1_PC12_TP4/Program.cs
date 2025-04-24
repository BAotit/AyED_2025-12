using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresomensual;
            Console.WriteLine("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tus ingresos mensuales: ");
            ingresomensual = int.Parse(Console.ReadLine());

            if ((edad > 19) && (ingresomensual <= 100000))
            {
                Console.WriteLine("Puedes cobrar la beca ");
            }
            else if ((edad < 19) && (ingresomensual == 0))
            {
                Console.WriteLine("Puedes cobrar la beca ");
            }
            else if ((edad == 19) && (ingresomensual <= 50000))
            {
                Console.WriteLine("Puedes cobrar la beca ");
            }
            else
            {
                Console.WriteLine("No puedes cobrar la beca ");
            }
            Console.ReadKey();
        }
    }
}
