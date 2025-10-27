using System;


namespace Borderlands_MVM
{
    class Program
    {
        // Arrays para almacenar los datos (máximo 20 personajes)
        static string[] nombres = new string[20];
        static string[] sagas = new string[20];
        static int[] fuerzas = new int[20];
        static int[] defensas = new int[20];
        static bool[] heroes = new bool[20];
        static int cant = 0; // cantidad actual de personajes

        static void Main()
        {
            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("\nBienvenido a Borderlands Multiverse Manager");
                Console.WriteLine("1. Nuevo");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: NuevoPersonaje(); break;
                    case 2: ConsultarPersonaje(); break;
                    case 3: ModificarPersonaje(); break;
                    case 4: EliminarPersonaje(); break;
                    case 5: MostrarPersonajes(); break;
                    case 6: Console.WriteLine("Saliendo..."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        // 💥 Crear nuevo personaje
        static void NuevoPersonaje()
        {
            if (cant >= 20)
            {
                Console.WriteLine("No se pueden agregar más personajes (límite 20).");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            // Validar que no exista el nombre
            for (int i = 0; i < cant; i++)
            {
                if (nombres[i].ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("Ese personaje ya existe.");
                    return;
                }
            }

            Console.Write("Saga: ");
            string saga = Console.ReadLine();
            Console.Write("Fuerza: ");
            int fuerza = int.Parse(Console.ReadLine());
            Console.Write("Defensa: ");
            int defensa = int.Parse(Console.ReadLine());
            Console.Write("¿Es héroe? (s/n): ");
            bool heroe = Console.ReadLine().ToLower() == "s";

            // Guardar datos
            nombres[cant] = nombre;
            sagas[cant] = saga;
            fuerzas[cant] = fuerza;
            defensas[cant] = defensa;
            heroes[cant] = heroe;
            cant++;

            Console.WriteLine("Personaje agregado con éxito.");
        }

        // 🔎 Consultar personaje por nombre
        static void ConsultarPersonaje()
        {
            Console.Write("Nombre a buscar: ");
            string n = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (nombres[i].ToLower() == n.ToLower())
                {
                    Console.WriteLine($"{nombres[i]} ({sagas[i]}) F:{fuerzas[i]} D:{defensas[i]} Héroe:{heroes[i]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No se encontró ese personaje.");
        }

        // ✏️ Modificar fuerza y defensa
        static void ModificarPersonaje()
        {
            Console.Write("Nombre a modificar: ");
            string n = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cant; i++)
            {
                if (nombres[i].ToLower() == n.ToLower())
                {
                    Console.Write("Nueva fuerza: ");
                    fuerzas[i] = int.Parse(Console.ReadLine());
                    Console.Write("Nueva defensa: ");
                    defensas[i] = int.Parse(Console.ReadLine());
                    encontrado = true;
                    Console.WriteLine("Personaje modificado correctamente.");
                }
            }

            if (!encontrado)
                Console.WriteLine("No se encontró ese personaje.");
        }

        // ❌ Eliminar personaje
        static void EliminarPersonaje()
        {
            Console.Write("Nombre a eliminar: ");
            string n = Console.ReadLine();
            bool eliminado = false;

            for (int i = 0; i < cant; i++)
            {
                if (nombres[i].ToLower() == n.ToLower())
                {
                    // Desplazar los datos una posición a la izquierda
                    for (int j = i; j < cant - 1; j++)
                    {
                        nombres[j] = nombres[j + 1];
                        sagas[j] = sagas[j + 1];
                        fuerzas[j] = fuerzas[j + 1];
                        defensas[j] = defensas[j + 1];
                        heroes[j] = heroes[j + 1];
                    }
                    cant--;
                    eliminado = true;
                    Console.WriteLine("Personaje eliminado.");
                    break;
                }
            }

            if (!eliminado)
                Console.WriteLine("No se encontró ese personaje.");
        }

        // 📋 Mostrar todos los personajes ordenados por nombre
        static void MostrarPersonajes()
        {
            // Ordenar con Array.Sort usando la misma lógica de índices
            Array.Sort(nombres, 0, cant, StringComparer.OrdinalIgnoreCase);
            // 👆 Esto ordena solo el array de nombres,
            // pero para mantener coherencia, lo hacemos manualmente abajo.

            // Ordenamiento manual para mantener todos los datos juntos
            for (int i = 0; i < cant - 1; i++)
            {
                for (int j = i + 1; j < cant; j++)
                {
                    if (nombres[i].CompareTo(nombres[j]) > 0)
                    {
                        // Intercambiar todos los datos
                        (nombres[i], nombres[j]) = (nombres[j], nombres[i]);
                        (sagas[i], sagas[j]) = (sagas[j], sagas[i]);
                        (fuerzas[i], fuerzas[j]) = (fuerzas[j], fuerzas[i]);
                        (defensas[i], defensas[j]) = (defensas[j], defensas[i]);
                        (heroes[i], heroes[j]) = (heroes[j], heroes[i]);
                    }
                }
            }

            Console.WriteLine("\n--- LISTA DE PERSONAJES ---");
            for (int i = 0; i < cant; i++)
                Console.WriteLine($"{nombres[i]} ({sagas[i]}) F:{fuerzas[i]} D:{defensas[i]} Héroe:{heroes[i]}");
        }
    }
}