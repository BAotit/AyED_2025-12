using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC12_TP3
{
    class Program
    {
      
        static string[,] encargos = new string[25, 5];
        static int NumEnc = 0;

        static void Main()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("---Menu Principal: Argentinian Truck Simulator---");
                Console.WriteLine("Encargos actuales: " + NumEnc);
                Console.WriteLine();
                Console.WriteLine("1. Crear nuevo encargo");
                Console.WriteLine("2. Mostrar todos los encargos");
                Console.WriteLine("3. Asignar camión a un encargo");
                Console.WriteLine("4. Mostrar todos los encargos asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Mostrar el encargo con mayor distancia");
                Console.WriteLine("7. Filtrar encargos por código de camión");
                Console.WriteLine("8. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una opción: ");
                string elec = Console.ReadLine();

                switch (elec)
                {
                    case "1": CrearEncargo(); break;
                    case "2": MostrarEncargos(); break;
                    case "3": AsignarCamion(); break;
                    case "4": MostrarEncargosAsignados(); break;
                    case "5": PromedioGananciaPorSede(); break;
                    case "6": EncargoMayorDistancia(); break;
                    case "7": FiltrarPorCamion(); break;
                    case "8": salir = true; break;
                }
            } while (!salir);
        }

        // ---------------- FUNCIONES ----------------

        static void CrearEncargo()
        {
            Console.Clear();
            if (NumEnc >= 25)
            {
                Console.WriteLine("No se pueden registrar más encargos. El máximo es 25.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("---Crear nuevo encargo---");
            Console.Write("Ingrese el código del camión: ");
            string CodCamion = Console.ReadLine();

            Console.Write("Ingrese la distancia (en km): ");
            string Distancia = Console.ReadLine();
            while (int.Parse(Distancia) < 0)
            {
                Console.WriteLine("La distancia debe ser un número positivo. Intente de nuevo.");
                Console.Write("Ingrese la distancia (en km): ");
                Distancia = Console.ReadLine();
            }

            string Sede;
            do
            {
                Console.Write("Ingrese la sede (BSAS, BB, MDQ): ");
                Sede = Console.ReadLine().ToUpper();
                if (Sede != "BSAS" && Sede != "BB" && Sede != "MDQ")
                    Console.WriteLine("Sede no válida. Intente de nuevo.");
            } while (Sede != "BSAS" && Sede != "BB" && Sede != "MDQ");

            Console.Write("Ingrese la ganancia: ");
            string Ganancia = Console.ReadLine();

            encargos[NumEnc, 0] = CodCamion;
            encargos[NumEnc, 1] = Distancia;
            encargos[NumEnc, 2] = Sede;
            encargos[NumEnc, 3] = Ganancia;
            encargos[NumEnc, 4] = "0";

            NumEnc++;
        }

        static void MostrarEncargos()
        {
            Console.Clear();
            Console.WriteLine("---Información de encargos---");

            if (NumEnc == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
            }
            else
            {
                Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
                Console.WriteLine("--------------------------------------------------------------------------------");
                for (int i = 0; i < NumEnc; i++)
                {
                    Console.WriteLine($"{encargos[i, 0]}\t\t{encargos[i, 1]}km\t\t{encargos[i, 2]}\t{encargos[i, 3]}$\t\t{encargos[i, 4]}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void AsignarCamion()
        {
            Console.Clear();
            Console.WriteLine("---Asignar camión a un encargo---");
            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int i = 0; i < NumEnc; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"{encargos[i, 0]}\t\t{encargos[i, 1]}km\t\t{encargos[i, 2]}\t{encargos[i, 3]}$\t\t{encargos[i, 4]}");
                }
            }

            Console.Write("Ingrese la fila del camión a asignar: ");
            int selec = int.Parse(Console.ReadLine());

            if (encargos[selec , 4] == "1")
            {
                Console.WriteLine("El camión ya está asignado.");
            }
            else
            {
                encargos[selec , 4] = "1";
                Console.WriteLine("Camión asignado correctamente.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void MostrarEncargosAsignados()
        {
            Console.Clear();
            Console.WriteLine("---Encargos asignados---");
            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");

            for (int i = 0; i < NumEnc; i++)
            {
                if (encargos[i, 4] == "1")
                {
                    Console.WriteLine($"{encargos[i, 0]}\t\t{encargos[i, 1]}km\t\t{encargos[i, 2]}\t{encargos[i, 3]}$\t\t{encargos[i, 4]}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void PromedioGananciaPorSede()
        {
            int sumaBSAS = 0, contBSAS = 0;
            int sumaBB = 0, contBB = 0;
            int sumaMDQ = 0, contMDQ = 0;

            Console.Clear();
            Console.WriteLine("---Promedio de ganancia por sede---");

            for (int i = 0; i < NumEnc; i++)
            {
                string Sede = encargos[i, 2];
                int Ganancia = int.Parse(encargos[i, 3]);

                if (Sede == "BSAS") { sumaBSAS += Ganancia; contBSAS++; }
                else if (Sede == "BB") { sumaBB += Ganancia; contBB++; }
                else if (Sede == "MDQ") { sumaMDQ += Ganancia; contMDQ++; }
            }

            Console.WriteLine(contBSAS > 0 ? $"Promedio BSAS: {sumaBSAS / contBSAS}$" : "No hay encargos en BSAS.");
            Console.WriteLine(contBB > 0 ? $"Promedio BB: {sumaBB / contBB}$" : "No hay encargos en BB.");
            Console.WriteLine(contMDQ > 0 ? $"Promedio MDQ: {sumaMDQ / contMDQ}$" : "No hay encargos en MDQ.");
            Console.ReadKey();
        }

        static void EncargoMayorDistancia()
        {
            int maxDist = 0;
            for (int i = 0; i < NumEnc; i++)
            {
                if (int.Parse(encargos[i, 1]) > maxDist)
                    maxDist = int.Parse(encargos[i, 1]);
            }

            Console.Clear();
            Console.WriteLine("---Encargo con mayor distancia---");
            for (int i = 0; i < NumEnc; i++)
            {
                if (int.Parse(encargos[i, 1]) == maxDist)
                {
                    Console.WriteLine($"{encargos[i, 0]}\t\t{encargos[i, 1]}km\t\t{encargos[i, 2]}\t{encargos[i, 3]}$\t\t{encargos[i, 4]}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void FiltrarPorCamion()
        {
            Console.Clear();
            Console.Write("Ingrese el código del camión a filtrar: ");
            string buscar = Console.ReadLine();

            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (encargos[i, 0] == buscar)
                {
                    Console.WriteLine($"{encargos[i, 0]}\t\t{encargos[i, 1]}km\t\t{encargos[i, 2]}\t{encargos[i, 3]}$\t\t{encargos[i, 4]}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
   
    
}
