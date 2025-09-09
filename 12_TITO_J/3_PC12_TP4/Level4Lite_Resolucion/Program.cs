using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        // TODO: implementar
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        
        // Usamos StringBuilder para construir la cadena resultante
        StringBuilder result = new StringBuilder();

        // Recorremos cada carácter de la cadena original
        foreach (char c in s)
        {
            char next; // variable para guardar el carácter cifrado

            if (char.IsLower(c)) // si es letra minúscula
            {
                // Operador ternario: si c es 'z', volvemos a 'a'; sino sumamos 1 al código ASCII
                next = (c == 'z') ? 'a' : (char)(c + 1);
            }
            else if (char.IsUpper(c)) // si es letra mayúscula
            {
                // Igual que antes pero para mayúsculas
                next = (c == 'Z') ? 'A' : (char)(c + 1);
            }
            else
            {
                // Si no es letra, lo dejamos igual
                next = c;
            }

            // Agregamos el carácter resultante al StringBuilder
            result.Append(next);
        }

        // Convertimos el StringBuilder a string normal y lo devolvemos
        return result.ToString();
    }
}
