using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_3
{
    class Program
    {
        static void Main(string[] args)
        {//Tp 3 etapa0
            //Declaramos las variables
            string nombre;
            int edad;
            //UI-Interfaz de Usuario->User Interfaz
            Console.WriteLine("¿Cual es tu nombre?");



            //Instancia el usuario
            nombre = Console.ReadLine();//Tomo valor por consola y lo igualo a nombre
            //Lee lo que escribes y lo tranforma entexto
            //Console.REadLine(nombre); = eso seria que solo lea esa variable, estamos forzando a que la variable entre en una funcion que supone
            //que lee lo que le ingresas.
       
        Console.WriteLine("Cual es tu edad?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + nombre+" Tu edad es " + edad);

            Console.ReadKey();

        }
    }
}
