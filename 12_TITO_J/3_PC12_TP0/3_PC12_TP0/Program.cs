using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC12_TP0
{
    class Program
    {
     
        /*
            Entrada: (Nombre) 
Proceso: Concatenar "Hola " + "Nombre"
Salida: (String)
            */
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

            }

        }  
}
