using System;
using System.Collections.Generic;
/*Crea un programa que pida frases al usuario (hasta que introduzca una
línea vacía), las almacene en un ArrayList y luego pregunte
de forma repetitiva al usuario qué línea desea ver. Terminará cuando el usuario
introduzca "-1"*/

class Program
{
    static void Main()
    {
        List<string> frases = new List<string>();
        string frase;
        do
        {
            Console.WriteLine("Introduce una frase:");
            frase = Console.ReadLine();
            if (frase != "")
            {
                frases.Add(frase);
            }
        } while (frase != "");
        int opcion;
        do
        {
            Console.WriteLine("¿Qué frase quieres ver (introduce - 1 para salir) ? ");
                opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion != -1)
            {
                Console.WriteLine(frases[opcion]);
            }
        } while (opcion != -1);
    }
}
