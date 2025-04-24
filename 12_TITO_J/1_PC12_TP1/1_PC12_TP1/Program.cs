using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña, contraseña2;
           
            Console.WriteLine(" Ingrese su contraseña");
            contraseña = "manzana";
            contraseña2 = Console.ReadLine();
            if ((contraseña2.ToUpper() ) == (contraseña.ToUpper()))

             {
                Console.WriteLine("La contraseña es correcta ");
             }
            else
            {
                Console.WriteLine("La contraseña no es correcta");
            }
            Console.ReadKey();
        }
    }
}
