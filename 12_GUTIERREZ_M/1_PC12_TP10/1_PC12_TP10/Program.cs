using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("0");
            for (int i = 1; i < 100; i++)
            {
                //MULTIPLO DE 3
                
                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }



            }

            Console.ReadKey();
        }
    }
}
