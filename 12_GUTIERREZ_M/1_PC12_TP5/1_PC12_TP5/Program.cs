using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP5
{
    class Program
    {
        static void Main(string[] args)
        {

            string comida, refugio, bate;

            Console.Write("tiene comida?");
            comida = Console.ReadLine();

            Console.Write("tiene un refugio?");
            refugio = Console.ReadLine();

            Console.Write("tiene un bate?");
            bate = Console.ReadLine();


            if ((comida.ToUpper() == "SI") && (refugio.ToUpper() == "SI") && (bate.ToUpper() == "SI"))
            {
                Console.Write("sobreviviras");

            }
            else if ((comida.ToUpper() == "NO") || (refugio.ToUpper() == "NO") || (bate.ToUpper() == "NO"))
            {
                Console.WriteLine("no sobreviviras");
            }


            Console.ReadKey();










        }


    }
}
