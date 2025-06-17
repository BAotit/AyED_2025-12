using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10 - SumandoMatrices

Sumar dos matrices de igual tamaño nxn, almacenarlas en una nueva e imprimirla por pantalla.
*/
            Random rand = new Random();

            int filas, columnas;

            // === Ingreso de tamaño de matrices ===
            Console.Write("Ingrese la cantidad de FILAS: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de COLUMNAS: ");
            columnas = int.Parse(Console.ReadLine());

            // === Crear matrices del mismo tamaño ===
            int[,] mimatriz = new int[filas, columnas];
            int[,] tumatriz = new int[filas, columnas];
            int[,] resultado = new int[filas, columnas];

            // === Llenar primera matriz con números aleatorios ===
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    mimatriz[f, c] = rand.Next(1, 101);
                }
            }

            // === Llenar segunda matriz con números aleatorios ===
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    tumatriz[f, c] = rand.Next(1, 101);
                }
            }

            // === Sumar ambas matrices y guardar el resultado ===
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    resultado[f, c] = mimatriz[f, c] + tumatriz[f, c];
                }
            }

            // === Mostrar Primera Matriz ===
            Console.WriteLine("\nPrimera matriz:");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            // === Mostrar Segunda Matriz ===
            Console.WriteLine("\nSegunda matriz:");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(tumatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            // === Mostrar Matriz Resultado ===
            Console.WriteLine("\nMatriz resultante (suma):");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(resultado[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();




        }
    
    }
}
