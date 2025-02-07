using System;
using System.Collections.Generic;

/*Crea un programa que pida frases al usuario (hasta que introduzca una
línea vacía), las almacene en un ArrayList y luego pregunte
de forma repetitiva al usuario qué texto desea buscar y muestre las líneas que
contienen ese texto. Terminará cuando el usuario introduzca una cadena vacía.*/
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
        string texto;
        do
        {
            Console.WriteLine("Introduce un texto a buscar:");
            texto = Console.ReadLine();
            if (texto != "")
            {
                foreach (string f in frases)
                {
                    if (f.Contains(texto))
                    {
                        Console.WriteLine(f);
                    }
                }
            }
        } while (texto != "");
    }
}
