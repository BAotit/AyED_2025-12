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

            // Variables
            int tps = 0;
            int examenes = 0;
            int nota_tps_total = 0;
            int nota_examenes_total = 0;
            float promedio_examenes = 0;
            int tps_aprobados = 0;

            // Interfaz + Cantidad de TPs y Exámenes
            Console.WriteLine("  === Bienvenido al sistema de Phineas y Ferb === ");
            Console.Write("Ingresar la cantidad de TPs: ");
            tps = int.Parse(Console.ReadLine()!);

            Console.Write("Ingresar la cantidad de Exámenes: ");
            examenes = int.Parse(Console.ReadLine()!);

            // Ingresar notas de los TPs
            int[] notas_tps = new int[tps];
            for (int i = 0; i < tps; i++)
            {
                Console.Write("Ingresar la nota del TP " + (i + 1) + ": ");
                notas_tps[i] = int.Parse(Console.ReadLine()!);
                nota_tps_total += notas_tps[i];

                if (notas_tps[i] >= 6)
                {
                    tps_aprobados++;
                }
            }

            // Ingresar notas de los exámenes
            int[] notas_examenes = new int[examenes];
            for (int i = 0; i < examenes; i++)
            {
                Console.Write("Ingresar la nota del Examen " + (i + 1) + ": ");
                notas_examenes[i] = int.Parse(Console.ReadLine()!);
                nota_examenes_total += notas_examenes[i];
            }

            // Calcular promedio de exámenes
            promedio_examenes = (float)nota_examenes_total / examenes;

            // Calcular porcentaje de TPs aprobados
            float porcentaje_tps_aprobados = ((float)tps_aprobados / tps) * 100;

            // Mostrar resultados
            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine("Promedio de exámenes: " + promedio_examenes);
            Console.WriteLine("Porcentaje de TPs aprobados: " + porcentaje_tps_aprobados + "%");

            // Verificar si aprueban
            if (promedio_examenes >= 6 && porcentaje_tps_aprobados >= 75)
            {
                Console.WriteLine("¡Phineas y Ferb pueden aprobar la materia! ");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO pueden aprobar la materia. ");
            }

            Console.ReadKey();
        }
    }
}
