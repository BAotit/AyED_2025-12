using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP9
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("DAME UN NUMERO ENTERO");
            numero = int.Parse(Console.ReadLine());

            for (int i = numero; i >0; i--)
            {
                Console.WriteLine(i -1 );
            }

            Console.ReadKey();
        }
    }
}
