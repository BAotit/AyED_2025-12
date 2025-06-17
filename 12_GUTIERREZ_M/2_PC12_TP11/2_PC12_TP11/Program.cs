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
            /*?????????????????????????????????????????????????????????
            11 - MatrizRotada90

            Rotar una matriz cuadrada n×n 90 grados en sentido horario.
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

            // Rotar 90° en sentido horario
            int[,] rotada = new int[tamaño, tamaño];
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    //calculp para rotar
                    //la c en q columna estoy 
                    //la f en  fila  estoy 
                    //el menos 1(ubicado en f)resta a donde estoy yo 

                    //1 (c) ,tamaño(total de fila)-1(donde estoy) - 0(f)
                    rotada[c, tamaño - 1 - f] = matriz[f, c];
                }
            }

            // Mostrar matriz rotada
            Console.WriteLine("\nMatriz rotada 90° en sentido horario:");
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    Console.Write(rotada[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}