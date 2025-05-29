using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
El promedio de las notas de los exámenes debe ser mayor o igual a 6.
Al menos el 75 % de los TPs deben tener una nota igual o mayor a 6.
 El sistema debe calcular el promedio de los exámenes y verificar si se cumplen las condiciones para aprobar la materia.Finalmente, debe mostrar en pantalla un mensaje indicando si Phineas y Ferb pueden aprobar la materia o no.
Permitir al usuario especificar la cantidad de TPs y exámenes.
Permitir al usuario ingresar las notas de cada TP y examen.
Calcular el promedio de las notas de los exámenes.
Verificar si se cumplen las condiciones para aprobar la materia.
Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia.

*/
//Valores
            int tps = 0;
            int examenes = 0;
            int nota_tps = 0;
            int nota_examenes = 0;
            float promedio = 0;
            int tpsAprobados = 0;

            //Interfaz + Cantidad de TPs y examenes

            Console.WriteLine("  === Bienvenido a El sistme de Phineas y Ferb === ");
            Console.WriteLine(" ingresar la cantidad de TPs :");

            tps = int.Parse(Console.ReadLine());

            Console.WriteLine(" ingresar la cantidad de Examenes :");

            examenes = int.Parse(Console.ReadLine());

            // Notas por cada TP y examen

            int[]  notas_1 = new int[tps];

            for (int i = 0; i < tps; i++)
            {

                Console.WriteLine("ingresar las notas de cada TP. " + (i + 1) + ": ");
                notas_1[i] = int.Parse(Console.ReadLine());
                nota_tps = nota_tps + notas_1[i];

                if (notas_1[i] >= 6)
                {
                tpsAprobados++; // contar cuántos TP tienen nota >= 6
                }
            }

        
            int[] notas_2 = new int[examenes];

            for (int i = 0; i < examenes; i++)
            {

                Console.WriteLine("ingresar las notas de cada Examen. " + (i + 1) + ": ");
                notas_2[i] = int.Parse(Console.ReadLine());
                nota_examenes = nota_examenes + notas_2[i];
            }


            //Calculo de promedio
            promedio = nota_examenes / examenes;

            // Calcular 75% de TPs necesarios
            int tpsNecesarios = (int)nota_tps * 0.75;

            // Verificar condiciones
            bool apruebaExamenes = promedio >= 6;
            bool apruebaTPs = tpsAprobados >= tpsNecesarios;


            Console.WriteLine("=== Resultados ===");
            Console.WriteLine("Promedio de exámenes: " + promedio);
            Console.WriteLine("TPs aprobados: " + tpsAprobados + " / " + tps);
            Console.WriteLine("Se necesitan al menos " + tpsNecesarios + " TPs aprobados (75%).");

            if (apruebaExamenes && apruebaTPs)
            {
                Console.WriteLine("Phineas y Ferb aprueban la materia!");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb no aprueban la materia");
            }
            Console.ReadKey();
        }
    }
}
