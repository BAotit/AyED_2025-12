using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, division;
                Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero2 == 0)
            {
                Console.WriteLine(" ERROR ");
            }
            else
            {
                division = numero1 / numero2;
                Console.WriteLine("Reasultado de la division:" + division);
            }

            

           
            
            
            Console.ReadKey();
            
        }
    }
}
