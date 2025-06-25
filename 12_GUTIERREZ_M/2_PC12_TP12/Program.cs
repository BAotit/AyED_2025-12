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
        {

            /*----------------------------------------------------------------------
            12 - ObtenerDiagonalPrincipal
Usando un for y un vector se debe obtener la diagonal principal de una Matriz nxn con datos aleatorios.      
*/
            int tamaño = 0;
            Random rand = new Random();

            // Ingresar tamaño (filas = columnas)
            Console.Write("Ingrese el tamaño de la matriz cuadrada: ");
            tamaño = int.Parse(Console.ReadLine());

            // Crear y llenar la matriz original
            int[,] matriz = new int[tamaño, tamaño];
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    matriz[f, c] = rand.Next(1, 101); // números entre 1 y 100
                }
            }

            // Mostrar matriz original
            Console.WriteLine("\nMatriz original:");
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            //COPIAR MATRIZ
            int[,] rotada = new int[tamaño, tamaño];
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    rotada[f, c] = matriz[f, c];
                }
            }

            // Mostrar matriz DIAGONAL
            Console.WriteLine("\nMatriz DIAGONAL");
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    if (f == c)
                        Console.Write(rotada[f, c] + "\t"); // mostramos solo si está en la diagonal
                    else
                        Console.Write("\t"); // espacio en blanco para mantener forma de matriz
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }

}



