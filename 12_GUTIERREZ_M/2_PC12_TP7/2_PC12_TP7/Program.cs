using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            int candidatos = 0;
            int n = 0;
            int numero = 0;
            string ordenar;
            Random rand = new Random();


            //1) Se crea un vector de tamaño n, donde n es un valor ingresado por el usuario.
            Console.WriteLine("  === Bienvenido  ");
            Console.Write("Ingresare tamaño del vector : ");
            n = int.Parse(Console.ReadLine());

            //2) Se utiliza la función Random para generar números aleatorios entre un rango definido y se llenan las posiciones del vector con estos valores.

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = rand.Next(1, 10);
            }

            ///

            do

            {
                Console.WriteLine("  === SIMULADOR GAMER === ");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1.Imprime en pantalla todos los elementos del vector. ");
                Console.WriteLine(" 2.ingresa un número y el programa busca si este usuario se encuentra en el vector");
                Console.WriteLine(" 3.vector de forma ascendente o descendente");
                Console.WriteLine("4.Salir del juego");

                //opciones
                string opcion = Console.ReadLine();

                switch (opcion)
                {


                    case "1":
                        Console.Clear();
                        //3) Se presenta al usuario un menú con las siguientes opciones:


                        //Imprime en pantalla todos los elementos del vector.

                        Console.WriteLine($"lista de  todos los elementos del vector. \r\n");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"numero {i}: {vector[i]} ");
                        }
                        break;

                    case "2":
                        Console.Clear();

                        //El ingresa un número y el programa busca si este usuario se encuentra en el vector. Si lo encuentra, se indica la posición en la que se encuentra.

                        Console.Write("ingrese un número : ");
                        numero = int.Parse(Console.ReadLine());

                        bool encontrado = false;

                        for (int i = 0; i < n; i++)
                        {

                            if (vector[i] == numero)
                            {
                                Console.WriteLine("el numero " + numero + " se encuentra en la posicion " + i);
                                encontrado = true;
                            }

                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("El número " + numero + " no se encuentra en el vector.");
                        }

                        break;

                    case "3":
                        Console.Clear();
                        //Se ordena el vector de forma ascendente o descendente, según la elección del usuario.
                        Array.Sort(vector);
                        Console.Write(" ordena el vector de forma ascendente o descendente?: ");
                        ordenar = Console.ReadLine();

                        if ((ordenar.ToUpper() == "ASCENDENTE"))
                        {
                            // Ordenar en orden ascendente (de menor a mayor)

                            //imprimir
                            for (int i = 0; i < vector.Length; i++)
                            {
                                Console.WriteLine("vector : " + vector[i]);
                            }
                        }
                        else if ((ordenar.ToUpper() == "DESCENDENTE"))
                        {
                            // Invertir para obtener el orden descendente (de mayor a menor)
                            Array.Reverse(vector);
                            //imprimir
                            for (int i = 0; i < vector.Length; i++)
                            {
                                Console.WriteLine("vector : " + vector[i]);
                            }
                        }

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("adios");
                        salir = true;
                        break;
                }
            } while (!salir);

            Console.ReadKey();

        }
    }
}
