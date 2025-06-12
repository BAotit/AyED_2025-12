using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
6 - ContratacionSoft

Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para un proyecto importante.
Durante el proceso de selección, necesitan un programa que ordene los puntajes obtenidos en un examen de menor a mayor,
y luego filtrar aquellos puntajes que sean múltiplos de un número dado.

El programa solicitará al usuario que ingrese la cantidad de candidatos que realizó el examen.
Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por uno.
Una vez ingresados todos los puntajes, el programa los ordenará de menor a mayor.
Posteriormente, el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes múltiplos de ese número.
Finalmente, mostrará al usuario la lista de puntajes ordenados y los puntajes que son múltiples del número especificado.
*/

            int candidatos = 0;
            int numero = 0;

            //El programa solicitará al usuario que ingrese la cantidad de candidatos que realizó el examen.

            Console.WriteLine("  === Bienvenido  a nuestro menu de selecccion");
            Console.Write("Ingresar la cantidad de candidatos que realizó el examen. : ");
            candidatos = int.Parse(Console.ReadLine());

            //Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por uno.

            int[] puntajes = new int[candidatos];

            for (int i = 0; i < candidatos; i++)
            {
                Console.Write("Ingresar el puntaje del examen del candidato " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            //Una vez ingresados todos los puntajes, el programa los ordenará de menor a mayor.

            Array.Sort(puntajes);

            // el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes múltiplos de ese número.

            Console.Write("ingrese un número entero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"lista de puntajes multiplos de : " + numero);
            for (int i = 0; i < candidatos; i++)
            {
                if (puntajes[i] % numero == 0)
                {

                    Console.WriteLine($"candidato /n{i + 1}: {puntajes[i]} ");
                }

            }

            //Finalmente, mostrará al usuario la lista de puntajes ordenados


            Console.WriteLine($"lista de puntajes ordenados \r\n");
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine($"candidato {i + 1}: {puntajes[i]} ");
            }
            Console.ReadKey();
        }
    }
}
