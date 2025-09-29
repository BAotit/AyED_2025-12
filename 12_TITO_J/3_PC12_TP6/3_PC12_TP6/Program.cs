using System;

namespace _3_PC12_TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");

            // 1) Generar mano aleatoria
            string[] mano = GenerarManoAleatoria();

            // 2) Determinar tipo de mano
            string tipo = TipoDeMano(mano);

            // 3) Calcular puntaje base
            int basePts = PuntajeBase(mano);

            // 4) Calcular multiplicador según el tipo
            double mult = Multiplicador(tipo);

            // 5) Aplicar jokers (ejemplo: true y true para probar)
            double total = AplicarJokers(basePts * mult, true, true);

            // 6) Mostrar resumen final
            MostrarResumen(mano, tipo, basePts, mult, total);

            Console.ReadKey();
        }

        // 1) Generar mano
        static string[] GenerarManoAleatoria()
        {
            char[] rangos = { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7', '6', '5', '4', '3', '2' };
            char[] palos = { 'H', 'D', 'C', 'S' };
            Random random = new Random();
            string[] mano = new string[5];

            for (int i = 0; i < 5; i++)
            {
                char rango = rangos[random.Next(rangos.Length)];
                char palo = palos[random.Next(palos.Length)];
                mano[i] = "" + rango + palo;
            }
            return mano;
        }

        // 2) Tipo de mano
        static string TipoDeMano(string[] mano)
        {
            int maxIguales = 1;
            bool hayPar = false;
            bool hayTrio = false;

            for (int i = 0; i < mano.Length; i++)
            {
                bool yaContado = false;
                for (int k = 0; k < i; k++)
                {
                    if (mano[k][0] == mano[i][0])
                    {
                        yaContado = true;
                        break;
                    }
                }
                if (yaContado) continue;

                int cont = 1;
                for (int j = i + 1; j < mano.Length; j++)
                {
                    if (mano[j][0] == mano[i][0]) cont++;
                }

                if (cont > maxIguales) maxIguales = cont;
                if (cont == 2) hayPar = true;
                if (cont == 3) hayTrio = true;
            }

            if (maxIguales == 4) return "Poker";
            if (hayTrio && hayPar) return "Full";
            if (hayTrio) return "Trio";
            if (hayPar) return "Par";
            return "Nada";
        }

        // 3) Puntaje base
        static int PuntajeBase(string[] mano)
        {
            int total = 0;
            foreach (string carta in mano)
            {
                char letra = carta[0];
                int numero = 0;
                switch (letra)
                {
                    case 'A': numero = 14; break;
                    case 'K': numero = 13; break;
                    case 'Q': numero = 12; break;
                    case 'J': numero = 11; break;
                    case 'T': numero = 10; break;
                    case '9': numero = 9; break;
                    case '8': numero = 8; break;
                    case '7': numero = 7; break;
                    case '6': numero = 6; break;
                    case '5': numero = 5; break;
                    case '4': numero = 4; break;
                    case '3': numero = 3; break;
                    case '2': numero = 2; break;
                }
                total += numero;
            }
            return total;
        }

        // 4) Multiplicador
        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Par": return 1.5;
                case "Trio": return 2.5;
                case "Full": return 3.5;
                case "Poker": return 4.0;
                default: return 1.0;
            }
        }

        // 5) Aplicar Jokers
        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2) puntaje *= 2;
            if (mas10) puntaje += 10;
            return puntaje;
        }

        // 6) Mostrar resumen
        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("\nMano: ");
            foreach (string carta in mano)
            {
                Console.Write("[" + carta + "] ");
            }
            Console.WriteLine();
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Total (con Jokers): " + total);
        }
    }
}
