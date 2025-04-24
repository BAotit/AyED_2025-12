using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_TP11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double ancho, alto, perimetro, area, diagonal;
          

            Console.WriteLine("introduce el ancho del rectangulo:");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("introduce el alto del rectangulo:");
            alto = int.Parse(Console.ReadLine());

            //perimetro
            perimetro = 2*(ancho + alto);

            //area
            area = ancho * alto;

            //diagonal
            diagonal = Math.Sqrt(Math.Pow(ancho, 2)+ Math.Pow(alto, 2));

            Console.WriteLine("resultado del perimetro :" + perimetro);
            Console.WriteLine("resultado del area:" + area);
            Console.WriteLine("resultado de la diagonal:" + diagonal);
            Console.ReadKey();

        }
    }
}
