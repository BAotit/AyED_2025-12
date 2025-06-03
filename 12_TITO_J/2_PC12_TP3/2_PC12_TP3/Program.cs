using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo
            Luego, pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.
            Una vez ingresados todos los puntajes, el programa los ordenará de mayor a menor.
            .Finalmente, mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) y el último lugar (menor puntaje).
            */
            // Variables
            int participantes = 0;
          
            
            

            // Interfaz + Cantidad de Participantes
            Console.WriteLine("  === Bienvenido  al Galaxy Quest === ");
            Console.Write("Ingresar la cantidad de participantes: ");
            participantes = int.Parse(Console.ReadLine());


            // Ingresar puntajes de los participantes
            int[] puntajes = new int[participantes];
            for (int i = 0; i < participantes; i++)
            {
                Console.Write("Ingresar el puntaje del participante " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            // Ordenar en orden ascendente (de menor a mayor)
            Array.Sort(puntajes);

            // Invertir para obtener el orden descendente (de mayor a menor)
            Array.Reverse(puntajes);

            // Mostrar resultados
            Console.WriteLine("\n=== Resultados ===");

            // Imprimir el vector ordenado
           
            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.WriteLine($"Puesto {i + 1}: {puntajes[i]} puntos");
            }

            // Mostrar el mejor y el peor puntaje
            Console.WriteLine($"\n Mejor puntaje: {puntajes[0]} puntos");
            Console.WriteLine($" Peor puntaje: {puntajes[puntajes.Length - 1]} puntos");

         
            Console.ReadKey();
        }
    }
}
