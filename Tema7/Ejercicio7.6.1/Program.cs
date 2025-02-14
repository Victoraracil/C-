using System;
using System.Collections.Generic;
/*Crea una versión alternativa del ejercicio 7.5.1, pero que tenga las
traducciones almacenadas en una tabla Hash.*/
class Program
{
    static void Main()
    {
        Dictionary<string, string> numeros = new Dictionary<string, string>(500);
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