using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC12_TP1
{
    class Program
    {
        
            /*
            Entrada: (Nombre) 
Proceso: Concatenar "Hola " + "Nombre"
Salida: (String)
           
            //Funcion
            static string Saludo(string nombre)
            {
                return "Hola " + nombre + ", bienvenido a C#!";
            }

            //Ejecuta
            static void Main(string[] args)
            {

                string nombre;

                Console.WriteLine("Ingresa un nombre");
                nombre = Console.ReadLine();
                string mensaje = Saludo(nombre);
                Console.WriteLine(mensaje);

                Console.ReadKey();

            Entrada: (Valor 1, Valor 2)
Proceso: (Valor1 + Valor2)
Salida: (Int)
                 */
         
            static int Suma(int a, int b) // función que devuelve un int
            {
                return a + b; // devuelve el resultado
            }
            static void Main(string[] args)
            {
            int a, b;

              Console.WriteLine("Ingresa UN NUMERO");
              a =int.Parse( Console.ReadLine());

            Console.WriteLine("Ingresa UN NUMERO");
            b = int.Parse(Console.ReadLine());
            int resultado = Suma(a,b);

               

Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey();
            }
        }


    }

    
