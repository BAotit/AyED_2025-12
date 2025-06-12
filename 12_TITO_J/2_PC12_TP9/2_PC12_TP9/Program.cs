using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9 - MatrizAleatoria

Llenar una matriz de n×m con valores aleatorios entre un rango dado (por ejemplo, 1 a 100).
*/
            int filas = 0;
            int columnas = 0;
            Random rand = new Random();
            // ingresar filas y columnas

            Console.Write("Ingrese la cantidad de FILAS: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());
            //Crear matriz
            int[,] mimatriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    int numeroaleatorio = rand.Next(1, 101);
                    mimatriz[f, c] = numeroaleatorio;
                }
            }

            //Imprimir la matriz
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
