using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP0
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine(" Ingrese su edad: ");

            edad = int.Parse(Console.ReadLine());
            if (edad > 18) 
                {
                Console.WriteLine("Eres mayor de edad ");
            }
            else if(edad == 18)
                {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
