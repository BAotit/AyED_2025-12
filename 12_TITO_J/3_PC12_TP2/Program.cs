/*
 Hacer una función que sume 2 números, una que reste, otra que multiplique 
y una que divida. Luego hacer una función llamada "Calculadora" 
que contenga un switch y dependiendo de la opción llame a cada función.
4 funciones y luego una funcion "Calculadora" que llame por opciones a las 4 funciones
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC12_TP2
{
    class Program
    {
        // Las 4 Funciones
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static double Division(int a, int b)
        {
            if (b == 0) //SI tratan de dividir por 0, aparecera error
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0; // Devuelvo 0 
            }
            return (double)a / b; // casteo a double para tener decimales
        }

        // Función Calculadora
        static void Calculadora(string opcion)//Void significa que no devuelve nada, sin return.
        {
            //Toma los numeros 1 sola vez para hacer las operaciones
            Console.WriteLine("Ingresa un número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro número:");
            int b = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("La suma es: " + Suma(a, b));//Llama a la funcion y al resultado de la funcion.
                    break;
                case "2":
                    Console.WriteLine("La resta es: " + Resta(a, b));
                    break;
                case "3":
                    Console.WriteLine("La multiplicación es: " + Multiplicacion(a, b));
                    break;
                case "4":
                    Console.WriteLine("La división es: " + Division(a, b));
                    break;
                default:
                    Console.WriteLine(opcion + " no es una opción válida");
                    break;
            }
        }

        // Programa principal
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Elije una opción:");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicación");
            Console.WriteLine("4: División");

            string opcion = Console.ReadLine(); //elijo una opcion
            Calculadora(opcion); // llamo a la función calculadora para que ejecute mi opcion.
            Console.ReadKey();
        }
    }
}
