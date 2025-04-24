using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_TP10
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Double celcius, kelvin, fahrenheit;
           

            Console.WriteLine("introduce los grados en celcius:");
            celcius = int.Parse(Console.ReadLine());

            kelvin = celcius + 273.15;

            fahrenheit = (celcius * 1.8)+32;

            Console.WriteLine("resultado en kelvin :" + kelvin);
            Console.WriteLine("resultado en fahrenheit:" + fahrenheit);
            Console.ReadKey();

        }
    }
}
