/*Objetivo: resolver 4 niveles cortos(funciones, vectores y matrices) 
/ TODO a completar.
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
        bool ok = Level1.ValidateAccessKey("WD-700000")
                  && !Level1.ValidateAccessKey("WD-123123")
                  && !Level1.ValidateAccessKey("WX-000007")
                  && !Level1.ValidateAccessKey("WD-00007");
        if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
        else Console.WriteLine("🔒 LOCKED");
    }
}

static class Level1
{
    // Debe devolver true solo si:
    // - Empieza por "WD-"
    // - Luego hay exactamente 6 dígitos
    // - La suma de esos 6 dígitos es múltiplo de 7
    public static bool ValidateAccessKey(string key)
    {

        // Revisar prefijo "WD-"
        if (!key.StartsWith("WD-"))// si no empieza con WD es false.
            return false;

        // Son 9 caracteres en total (3 + 6 digitos)
        if (key.Length != 9)
            return false;

        // Revisar que los últimos 6 sean dígitos
        int suma = 0;
        for (int i = 3; i < key.Length; i++) // desde el 4to char en adelante
        {
            char c = key[i];
            if (!char.IsDigit(c))
                return false; // si alguno no es dígito, no es válido

            suma += c - '0'; // convertir char → el número y lo voy sumando, asi los acumulo.
        }

        //VEmos que sea múltiplo de 7
        return (suma % 7 == 0);
    }


}