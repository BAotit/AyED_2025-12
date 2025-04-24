using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            ////////
            

            string nombre = "Jugador1";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;

            string espada;


            ///

            do

            {
                Console.WriteLine("  === SIMULADOR GAMER === ");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1.Mostrar estado del jugador ");
                Console.WriteLine(" 2.Encontrar espada mágica");
                Console.WriteLine(" 3.Pelear contra un enemigo");
                Console.WriteLine("4.Comprar poción de vida(vale 20 monedas) ");
                Console.WriteLine("5.Salir del juego");

                //opciones
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("nombre "+ nombre);
                        Console.WriteLine("salud " +salud);
                        Console.WriteLine("monedas " + monedas);
                        Console.WriteLine("enemigos " + enemigosDerrotados);
                        Console.WriteLine("tieneEspada "+ tieneEspada);

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("tienes espada ?");

                        espada = Console.ReadLine();

                        
                        
                        if ((espada.ToUpper()=="NO") && (tieneEspada == false))
                        {
                            Console.WriteLine("¡Encontraste la espada mágica!");
                            tieneEspada = true;
                        }
                        else if((espada.ToUpper() == "SI"))
                        {
                            Console.WriteLine("Ya tenés la espada mágica.");
                        }


                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("tienes espada ?");

                        espada = Console.ReadLine();

                        if ((espada.ToUpper() == "SI"))
                        {
                            salud = salud - 10;
                            enemigosDerrotados = enemigosDerrotados + 1;
                            Console.WriteLine("¡Ganaste la batalla!  salud" + salud);
                            
                        }
                        else if ((espada.ToUpper() == "NO"))
                        {
                            salud = salud - 30;
                            Console.WriteLine("¡Fue una pelea dura sin espada!: salud " + salud);
                            Console.WriteLine("enemigosDerrotado "+ (enemigosDerrotados = enemigosDerrotados+1));

                        }
               
                        break;

                    case "4":
                        Console.Clear();

                        if (monedas >= 20 )
                        {
                            monedas = monedas - 20;
                            Console.WriteLine("monedas " + monedas);
                            salud = salud + 20;
                            Console.WriteLine("salud " + salud);

                        }
                        else if ((monedas < 20))
                        {
                            
                            Console.WriteLine("No tenés suficientes monedas.");
                        }

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
