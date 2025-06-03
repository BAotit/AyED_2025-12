using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP5
{
    class Program
    {
        static void Main(string[] args)
        {
  

            int objetos = 0;
            int valor_min = 0;
           

            //El programa solicitará al usuario que ingrese la cantidad de elementos (objetos) que desea analizar.
            Console.WriteLine("  === Bienvenido  al juego de rol (RPG) === ");
            Console.Write("Ingresar la cantidad de objetos: ");
            objetos = int.Parse(Console.ReadLine());


            //Luego, pedirá al usuario que ingrese el valor mínimo que deben tener losobjetos para ser considerados en el filtro.
            Console.Write("Ingresar el puntaje MINIMO de los objeto : ");
             valor_min = int.Parse(Console.ReadLine());
            
 

            //Seguidamente, el programa solicitará al usuario que ingrese los valores de los objetos, uno por uno.

            int[] puntajes = new int[objetos];
            int[] puntajes_2= new int[objetos];
            for (int i = 0; i < objetos; i++)
            {
                Console.Write("Ingresar el puntaje del objeto " + (i + 1) + ": ");
                 puntajes[i] = int.Parse(Console.ReadLine());
     
              
                
            }

            for (int i = 0; i < objetos; i++)
            {
              

                if (puntajes[i] >= valor_min)
                {
                    Console.WriteLine($"objeto {i + 1 }: {puntajes[i]} ");
                }

            }

            /*
         .  Una vez ingresados todos los valores,
            el programa mostrará al usuario las posiciones en las que se encuentran los objetos cuyo
            valor es mayor al número especificado.
            */








            Console.ReadKey();
        }
    }

}



