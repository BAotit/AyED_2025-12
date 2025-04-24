using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP15
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 0;
            dia = dia + 1;
            
            bool sigueVivo = true;
            Random rand = new Random();
            int probabilidad = rand.Next(1, 101);
            bool salir = false;
            

            ///

            do

            { 
                Console.WriteLine("  === SIMULADOR GAMER === ");
                Console.WriteLine("  Día"+ (dia)+"¿Qué querés hacer? ");
                Console.WriteLine("1. Buscar comida ");
                Console.WriteLine(" 2. Dormir");
                Console.WriteLine(" 3.Explorar la isla");
                Console.WriteLine("4.Ver estado del personaje ");
                Console.WriteLine("5.Salir del juego");
                Console.WriteLine("Seleccione una opción:");
                

                //opciones
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("hambre " + (hambre+20));
                        Console.WriteLine("energia " + (energia-15));
                        
                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("Comiste algo en mal estado.Salud - 15:" + (salud-15));
                        }
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                            sigueVivo = false;
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("energia: " + (energia + 30));
                        Console.WriteLine("hambre: " + (hambre - 10));
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                            sigueVivo = false;
                        }

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("energia: " + (energia - 20));
                        Console.WriteLine("hambre: " + (hambre - 15));

                        if (probabilidad <= 50)
                        {
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10." + (salud + 10));
                        }
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                            sigueVivo = false;
                        }
                        break;

                    case "4":
                        Console.Clear();

                        Console.Clear();
                        Console.WriteLine("Dia: " + dia);
                        Console.WriteLine("hambre " + hambre);
                        Console.WriteLine("salud " + salud);
                        Console.WriteLine("energia " + energia);
                        Console.WriteLine("Sigue vivo " + sigueVivo);

                        break;


                    case "5":
                        Console.Clear();
                        Console.WriteLine("adios");
                        salir = true;
                        break;




                }
            } while (!salir);
        }
}
    }
