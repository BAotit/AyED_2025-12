using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*calcular el promedio de comida que necesitará por invitado.
             El programa solicitará al usuario que ingrese la cantidad de invitados 
             y luego pedirá la cantidad de comida que cada invitado consume,
             asegurándose de que los valores ingresados estén dentro del rango permitido (de 1 a 100). 
             Una vez que se hayan ingresado todos los datos, el programa calculará el promedio de comida
             por invitado y lo mostrará en pantalla.
             */
            int invitados;
            int totalcomida = 0;
            int promedio = 0;

            Console.WriteLine("  === Bienvenido a la fiesta de stitch === ");
            Console.WriteLine(" Ingrese la cantidad de invitados a la fiesta:");

            invitados = int.Parse(Console.ReadLine());

            int[] Comidainvitados = new int[invitados];

            for (int i = 0; i< invitados; i++)
            {

                Console.WriteLine("Ingrese cantidad de comida del invitado" + i+ ": ");
                Comidainvitados[i] = int.Parse(Console.ReadLine());
                totalcomida = totalcomida + Comidainvitados[i];

            }

            promedio = totalcomida / invitados;
            Console.WriteLine("Promedio:" + (promedio));
            Console.ReadKey();
        }
    }
}
