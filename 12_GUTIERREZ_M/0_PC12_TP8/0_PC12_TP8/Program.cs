using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado, num1, num2;

            Console.WriteLine("introduce dos numeros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 % num2;
            Console.WriteLine("resultado :" + resultado);
            Console.ReadKey();
        

        }
    }
}
