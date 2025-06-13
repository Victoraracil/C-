using System;
/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */
public class Program
{
    public static void Main(string[] args)
    {
        string cadena = "Hola mundo";
        Console.WriteLine("Cadena normal: Hola mundo");
        Console.WriteLine("Cadena invertida: ", InvertirCadena(cadena));
    }
    public static string InvertirCadena(string cadena)
    {
        string cadenareves = "";
        for (int i = 0; i < cadena.Length; i++)
        {
            cadenareves += cadena[cadena.Length - i];
        }
        return cadenareves;
    }
}
