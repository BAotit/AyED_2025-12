using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC12_3

    
    {
        static void Main(string[] args)
        {//TP2 Etapa 0
            //DEclaramos variables
            string nombre; //Almacena un nombre en minuscula, es una variable.
            int edad; //Almacena un numero
            //Instanciamos/igualamos.
            nombre = "Brisa Tito";  edad = 15;
            //Imprimimos
            Console.WriteLine("Hola "+ nombre+ " tu edad es "+ edad);//Concatenamos las variables, seria juntar dos variables distintas, tenemos el texto
            //y una variable, queremos que ambas estan en una sola variable.
            Console.ReadKey();
        }

    }
}
