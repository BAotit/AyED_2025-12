using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC12_TP11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string tipo;
            string nivel;
            int estado = 0;
            int investigador = 0;

            int columnas = 5;
            int filas;
            int filasmax = 75;
            bool salir = false;

            Random rand = new Random();

            // Validar cantidad inicial fuera del menú
            do
            {
                Console.Write("¿Cuántos Pochimons querés registrar? (máx. 25): ");
                filas = int.Parse(Console.ReadLine());

                if (filas > filasmax)
                    Console.WriteLine("No hay más espacio... ¡Estamos a Full!");

            } while (filas > filasmax);
            string[,] pochimons = new string[filas, 5];
            do
            {

                Console.WriteLine("  === SIMULADOR GAMER === ");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Registrar Pochimon ");
                Console.WriteLine("2.Asignar Investigador a Pochimon");
                Console.WriteLine("3.Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5.Mostrar Información de Pochimons");
                Console.WriteLine("6.Buscar Pochimons por Tipo");
                Console.WriteLine("7.Mostrar Pochimons por Investigador");
                Console.WriteLine("8.Mostrar Pochimons Picados");
                Console.WriteLine("9.Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opción deseada: ");
                string opcion = Console.ReadLine();



                switch (opcion)
                {
                    case "1":
                        Console.Clear();





                        for (int f = 0; f < filas; f++)
                        {
                            Console.WriteLine("pochimon : " + f);

                            Console.Write("Nombre: ");
                            pochimons[f, 0] = Console.ReadLine();

                            /// esto para confirmar q pongo bien la letra
                            while (true)
                            {
                                Console.Write("Tipo (A/F/P): ");
                                pochimons[f, 1] = Console.ReadLine().ToUpper();

                                if (pochimons[f, 1] == "A" || pochimons[f, 1] == "F" || pochimons[f, 1] == "P")
                                {
                                    break; // válido, salgo del ciclo
                                }
                                else
                                {
                                    Console.WriteLine("Tipo inválido. Ingrese A, F o P.");
                                }
                            }

                            Console.Write("Nivel: ");
                            pochimons[f, 2] = Console.ReadLine();

                            pochimons[f, 3] = estado.ToString(); // Estado
                            pochimons[f, 4] = investigador.ToString(); ; // Investigador
                        }


                        break;

                    case "2":
                        Console.Clear();
                        /*
                 Asignar Investigador a Pochimon: Mostrará una lista de Pochimons no investigados (estado 0) y permitirá
                al usuario seleccionar uno. Luego, solicitará el código numérico del investigador para asignarlo al Pochimon y cambiará su estado a 1.
                */
                        // y aqui debo verificar q el pochimon este en el sistema

                        Console.WriteLine("fila\tNombre\tTipo\tNivel");
                        for (int f = 0; f < filas; f++)
                        {
                            Console.Write($"{f}\t");
                            for (int c = 0; c < 3; c++)
                            {
                                Console.Write(pochimons[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }


                        // aqui me tengo q asegurar q el pochimon se encuentre aqui

                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        int i = int.Parse(Console.ReadLine());

                        //el i se fija q este en alguna fila
                        if (i >= 0 && i < filas)
                        {
                            // solicitará el código numérico del investigador para asignarlo al Pochimon y cambiará su estado a 1.
                            Console.Write("Ingrese el código del Investigador: ");
                            investigador = int.Parse(Console.ReadLine());

                            estado = 1;

                            pochimons[i, 3] = estado.ToString(); // Estado
                            pochimons[i, 4] = investigador.ToString(); ; // Investigador
                        }
                        else
                        {
                            Console.WriteLine("fila inválida. No existe ese Pochimon.");
                        }

                        break;

                    case "3":
                        Console.Clear();
                        /*
                         *  Actualizar Nivel de Pochimon: Permitirá al usuario ingresar el número de fila de un Pochimon
                        y su nuevo nivel se incrementará en un número aleatorio entre 1 y 3.
                         */

                        Console.WriteLine("Fila\tNombre\tNivel");

                        for (int f = 0; f < filas; f++)
                        {
                            Console.Write($"{f}\t");
                            Console.Write($"{pochimons[f, 0]}\t"); // Nombre
                            Console.WriteLine($"{pochimons[f, 2]}"); // Nivel
                        }


                        //el i se fija q este en alguna fila
                        Console.Write("Ingrese el número de fila del Pochimon a subir de nivel: ");
                        i = int.Parse(Console.ReadLine());

                        if (i >= 0 && i < filas)
                        {
                            int nivelActual = int.Parse(pochimons[i, 2]);
                            int incremento = rand.Next(1, 4); // entre 1 y 3 inclusive
                            int nuevoNivel = nivelActual + incremento;

                            pochimons[i, 2] = nuevoNivel.ToString();
                        }

                        else
                        {
                            Console.WriteLine("fila inválida. No existe ese Pochimon.");
                        }

                        break;

                    case "4":
                        Console.Clear();
                        /*
                         Marcar Pochimon como Investigado: Mostrará todos los Pochimons en estado de investigación
                         y permitirá cambiar el estado de un Pochimon de "en investigación" a "investigado".
                        */

                        //Tenés que comparar con el string "1" (entre comillas):
                        Console.WriteLine("fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                        for (int f = 0; f < filas; f++)
                        {
                            if (pochimons[f, 3] == "1")// Estado "en investigación"
                            {
                                Console.Write($"{f}\t");
                                for (int c = 0; c < columnas; c++)
                                {
                                    Console.Write(pochimons[f, c] + "\t");
                                }
                                Console.WriteLine();

                            }
                        }
                        Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");

                        i = int.Parse(Console.ReadLine());

                        if (i >= 0 && i < filas)
                        {
                            estado = 2;

                            pochimons[i, 3] = estado.ToString();

                        }
                        else
                        {
                            Console.WriteLine("fila inválida. No existe ese Pochimon.");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        /*
                         Mostrar Información de Pochimons: Mostrará en pantalla todos los Pochimons registrados con todos sus atributos.
                        */
                        Console.WriteLine("fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                        for (int f = 0; f < filas; f++)
                        {
                            Console.Write($"{f}\t");
                            for (int c = 0; c < columnas; c++)
                            {
                                Console.Write(pochimons[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                        tipo = Console.ReadLine().ToUpper();

                        bool encontrado = false;

                        Console.WriteLine("fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");

                        for (int f = 0; f < filas; f++)
                        {
                            if (pochimons[f, 1].ToUpper() == tipo)
                            {
                                Console.Write($"{f}\t");
                                for (int c = 0; c < columnas; c++)
                                {
                                    Console.Write(pochimons[f, c] + "\t");
                                }
                                Console.WriteLine();
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontraron Pochimons de ese tipo.");
                        }
                        break;

                    case "7":
                        Console.Clear();
                        /*
                       Mostrar Pochimons por Investigador: Solicitará al usuario ingresar el código numérico de
                        un investigador y mostrará todos los Pochimons asignados a ese investigador.
                        */

                        Console.Clear();
                        Console.Write("Ingrese el código del Investigador: ");
                        investigador = int.Parse(Console.ReadLine());

                        bool encontrad = false;

                        Console.WriteLine("fila\tNombre\tTipo\tNivel");

                        for (int f = 0; f < filas; f++)
                        {
                            if (pochimons[f, 4] == investigador.ToString())
                            {
                                Console.Write($"{f}\t");
                                for (int c = 0; c < columnas - 2; c++)
                                {
                                    Console.Write(pochimons[f, c] + "\t");
                                }
                                Console.WriteLine();
                                encontrad = true;
                            }
                        }

                        if (!encontrad)
                        {
                            Console.WriteLine("No se encontraron Pochimons de ese tipo.");
                        }

                        break;
                    case "8":
                        Console.Clear();
                        //  Mostrar Pochimons Picados: Mostrará todos los Pochimons cuyo nivel es mayor a 30.

                        Console.Clear();
                        Console.WriteLine("Pochimons cuyo nivel es mayor a 30:");
                        int pochi30 = 30;
                        bool encontra = false;

                        for (int f = 0; f < filas; f++)
                        {
                            //Para evitar eso, conviene usar int.TryParse que chequea si el valor puede convertirse a número antes de comparar:
                            if (int.Parse(pochimons[f, 2]) > pochi30)
                            {
                                if (!encontra)
                                {
                                    Console.WriteLine("fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                                    encontra = true;
                                }

                                Console.Write($"{f}\t");
                                for (int c = 0; c < columnas; c++)
                                {
                                    Console.Write(pochimons[f, c] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }

                        if (!encontra)
                        {
                            Console.WriteLine("No se encontraron Pochimons de este nivel.");
                        }

                        break;
                    case "9":
                        salir = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (!salir);

            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }

}