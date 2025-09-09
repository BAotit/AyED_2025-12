using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC12_TP5
{

    class Program
    {

        static void Main()
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;
            Console.WriteLine("=== Hollow Knight: Simulador básico ===");
            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.Write("\nAcción (atacar/curar/salir): ");
                string accion = Console.ReadLine();
                if (accion == "atacar")
                {
                    hpEnemigo = Atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = Curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción no válida.");


                }
                // Enemigo ataca automáticamente
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
                }
            }
            Console.WriteLine("\n=== Resultado ===");
            if (hpHornet <= 0) Console.WriteLine("Hornet ha caído...");
            else if (hpEnemigo <= 0) Console.WriteLine("¡Hornet ganó!");
            else Console.WriteLine("Batalla interrumpida.");

            Console.ReadKey();
        }

        // ACA DEBEN CREAR LAS FUNCIONES:
        // 1) Atacar

        /*Atacar
        Parámetros: int atk , int hpEnemigo
        Retorna: int (nuevo HP del enemigo)
        Acción: resta el ataque al HP enemigo y devuelve el valor actualizado.

            2. Curar
Parámetros: int hpHornet , int hpMaxHornet
Retorna: int (nuevo HP de Hornet)
Acción: suma 5 de HP a Hornet, sin superar su máximo.

            3. MostrarEstado
Parámetros: int hpHornet , int hpEnemigo
Retorna: void
Acción: muestra en pantalla el estado actual de Hornet y del enemigo.
Ejemplo:
Hornet HP: 8 | Enemigo HP: 10
        */

        static int Atacar(int atkHornet, int hpEnemigo)
        {
            hpEnemigo = hpEnemigo - atkHornet;
            return hpEnemigo;
        }

        static int Curar(int hpHornet, int hpMaxHornet)
        {
            if (hpHornet <= hpMaxHornet)
            {
                hpHornet += 5;

            }
            return hpHornet;

        }
        static void MostrarEstado(int hpHornet, int hpEnemigo)
        {
            Console.WriteLine("Hornet HP:"+ hpHornet+ " | Enemigo HP:" + hpEnemigo);
            
        }   

    }

}





