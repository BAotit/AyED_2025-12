using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8 - MiPrimerMatriz

Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla

n y m son datos que ingresa el usuario
*/
            int filas = 0;
            int columnas = 0;
            // ingresar filas y columnas
         
            Console.Write("Ingrese la cantidad de FILAS: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] mimatriz = new int[filas, columnas];
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < filas; c++)
                {
                    mimatriz[f,c] = 0;
                }
            }
            //Imprimir la matriz
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < filas; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
