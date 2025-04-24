using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC12_TP13
{
    class Program
    {
        static void Main(string[] args)
        { bool salir = false;

            do
            {
                Console.WriteLine(" MENU DE OPCIONES: ");
                Console.WriteLine(" 1-SALUDAR ");
                Console.WriteLine(" 2-CANTAR ");
                Console.WriteLine(" 3-CONTAR CHISTE ");
                Console.WriteLine("4-SALIR ");

                //opciones
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("hola ");
                        break;

                    case "2":
                        Console.WriteLine("la vaca Lola tiene cabeza y tiene cola y hace muuuuu... ");
                        break;

                    case "3":
                        Console.WriteLine("fui al medico por amnesia...pero se me olvido por que jajajaja ");
                        break;

                    case "4":
                        Console.WriteLine("adios");
                        salir = true;
                        break;

                }
            } while (!salir);
                
             

           
        

        }
    }
}
