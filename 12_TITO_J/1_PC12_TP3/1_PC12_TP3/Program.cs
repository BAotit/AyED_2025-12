using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine(" Ingrese un numero entero: ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero == 0)
                
            {
                Console.WriteLine("el numero es neutro");
                
            }
            else if((numero % 2) == 1)
            {
                Console.WriteLine("el numero es impar");
            }
            else if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero es par");
            }
            Console.ReadKey();
        }
    }
}
