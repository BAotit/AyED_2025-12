using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
Permitir al Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos. Utiliza un array para almacenar estos tiempos.
Calcular y mostrar en pantalla el tiempo total de la carrera.
Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor tiempo registrado.
El programa debe permitir al usuario ingresar la cantidad de vueltas que horneó Rayo McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, se mostrarán las estadísticas calculadas.

(Opcional: los tiempos se pueden ingresar automáticamente con un for y un Random... recordar nombreRandom.Next(10, 500) ).
  */
            int vuelta;
            int segundos = 0;
            float promedio = 0;

            int mejorTiempo = int.MaxValue;
            int mejorVuelta = 0;

            Console.WriteLine("  === Bienvenido a El Rayo Carrera Veloz === ");
            Console.WriteLine(" ingresar la cantidad de vueltas:");

            vuelta = int.Parse(Console.ReadLine());

            int[] tiempo_vuelta = new int[vuelta];

            for (int i = 0; i < vuelta; i++)
            {

                Console.WriteLine("ingresar los tiempos de cada vuelta de la carrera en segundos. " + (i + 1) + ": ");
                tiempo_vuelta[i] = int.Parse(Console.ReadLine());
                segundos = segundos + tiempo_vuelta[i];

                if (tiempo_vuelta[i] < mejorTiempo)
                {
                    mejorTiempo = tiempo_vuelta[i];
                    mejorVuelta = i + 1; // guardás la vuelta correcta directamente
                }
            }



            Console.WriteLine("tiempo total de la carrera : " + segundos);

            promedio = segundos / vuelta;
            Console.WriteLine("Promedio:" + (promedio));

            Console.WriteLine("La mejor vuelta fue la vuelta " + mejorVuelta + " con un tiempo de " + mejorTiempo + " segundos.");

            Console.ReadKey();



        }
    }
}
