using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP11
{
    class Program
    {
        static void Main(string[] args)
        {/*----------------------------------------------------

13 - CalificacionesEstudiantiles

Crear una matriz Nx3 donde cada fila representa un estudiante y cada columna contiene información como el nombre, la edad y la calificación.
*/

            int fila = 3;
            int columna = 3;
            string[] nombres = { "dalila", "brisa", "juan" };

            Random rand = new Random();


            string[,] estudiante = new string[fila, columna];

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    switch (c)
                    {
                        case 0:
                            estudiante[f, c] = nombres[rand.Next(nombres.Length)];
                            break;
                        case 1:
                            estudiante[f, c] = rand.Next(13, 18).ToString();
                            break;
                        case 2:
                            estudiante[f, c] = rand.Next(1, 11).ToString();
                            break;
                    }
                }
            }

            // Mostrar los 3 alumnos
            Console.WriteLine("alumnos registrados:");

            Console.WriteLine($"Nombre:  edad:  calificacion:   ");


            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {

                    Console.Write(estudiante[f, c] + "\t ");
                }
                Console.WriteLine();
            }






            Console.ReadKey();
        }
    }

}