using System;
/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */
public class Program
{
    public static void Main()
    {
        Anagrama anagrama = new Anagrama();
        Console.WriteLine("Introduce la palabra original");
        string palabra1 = Console.ReadLine();
        Console.WriteLine("Introduce el Anagrama");
        string palabra2 = Console.ReadLine();
        Console.WriteLine(anagrama.ComprobarAnagrama(palabra1, palabra2));
    }
}
