using System;
/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */
public class Program
{
    public static void Main(string[] args)
    {
        string[] palabras = {"Hola", "mundo", "CSharp", "PROGRAMACION", "csharp", "Hola", "algoritmo", "Mundo", "baseDeDatos", "BaseDeDatos", "PROgramacion"};

        palabras = Ordenar.RepitoPalabra(palabras);
        for(int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
        }
    }
}
