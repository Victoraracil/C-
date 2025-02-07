using System;
using System.Collections.Generic;

/*Crea un programa que, cuando el usuario introduzca el nombre de un
número del 1 al 10 en inglés (por ejemplo, "two"), diga su traducción en español
(por ejemplo, "dos").*/

class Program
{
    static void Main()
    {
        Dictionary<string, string> numeros = new Dictionary<string, string>();
        numeros.Add("one", "uno");
        numeros.Add("two", "dos");
        numeros.Add("three", "tres");
        numeros.Add("four", "cuatro");
        numeros.Add("five", "cinco");
        numeros.Add("six", "seis");
        numeros.Add("seven", "siete");
        numeros.Add("eight", "ocho");
        numeros.Add("nine", "nueve");
        numeros.Add("ten", "diez");
        Console.Write("Introduce un número en inglés: ");
        string numero = Console.ReadLine();
        if (numeros.ContainsKey(numero))
        {
            Console.WriteLine(numeros[numero]);
        }
        else
        {
            Console.WriteLine("Número no encontrado");
        }
    }
}