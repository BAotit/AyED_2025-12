// See https://aka.ms/new-console-template for more information
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
            /*El programa solicitará al usuario que ingrese la cantidad de productos vendidos durante el Hot Sale. 
            Luego, pedirá al usuario que ingrese el precio de cada producto, uno por uno. 
            Una vez ingresados todos los precios, el programa determinará cuál fue el precio más alto y cuál fue el precio más bajo. 
            Finalmente, mostrará al usuario los precios más alto y más bajo registrados durante el evento.
             */

            // Variables
            int productos = 0;




            // Interfaz + Cantidad de Productos
            Console.WriteLine("  === Bienvenido  al Hot sale === ");
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            productos = int.Parse(Console.ReadLine());


            // Ingresar precio de los productos
            int[] precios = new int[productos];
            for (int i = 0; i < productos; i++)
            {
                Console.Write("Ingresar el precio del producto " + (i + 1) + ": ");
                precios[i] = int.Parse(Console.ReadLine()); //EL puntaje 1 va a ser igual a lo que ingrese
            }

            // Ordenar en orden ascendente (de menor a mayor)
            Array.Sort(precios);

            // Invertir para obtener el orden descendente (de mayor a menor)
            Array.Reverse(precios);

            // Mostrar resultados
            Console.WriteLine("\n=== Resultados ===");

            // Imprimir el vector ordenado
            /*
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine($"Producto {i + 1}: $ {precios[i]} ");
            }
            */
            // Mostrar el mejor y el peor puntaje
            Console.WriteLine($"\n Precio mas alto: $ {precios[0]} ");
            Console.WriteLine($" Precio mas bajo: $ {precios[precios.Length - 1]} ");


            Console.ReadKey();
        }
    }
}