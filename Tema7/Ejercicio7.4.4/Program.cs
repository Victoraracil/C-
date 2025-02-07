using System;
using System.Collections.Generic;
/*Crea un programa que pida frases al usuario (hasta que introduzca una
línea vacía), las almacene en un ArrayList luego muestre en pantalla las líneas
impares (primera, tercera, etc.) y finalmente muestre las líneas pares (segunda,
cuarta, etc.)*/

class Program
{
    public static void Main(string[] args)
    {
        List<string> frases = new List<string>();
        string frase;
        int i = 0;
        do
        {
            Console.WriteLine("Introduce una frase:");
            frase = Console.ReadLine();
            if (frase != "")
            {
                frases.Add(frase);
            }
        } while (frase != "");
        Console.WriteLine("Frases impares:");
        for (i = 0; i < frases.Count; i += 2)
        {
            Console.WriteLine(frases[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Frases pares:");
        for (i = 1; i < frases.Count; i += 2)
        {
            Console.WriteLine(frases[i]);
        }
    }
}
