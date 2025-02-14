using System;
using System.Collections.Generic;
/*Crea un programa que pida al usuario 10 palabras. Después preguntarás
una nueva palabra y dirás si está entre las 10 iniciales, empleando para ello un
conjunto. La petición de palabras a buscar debe repetirse hasta que se introduzca
una cadena vacía.*/
class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string>();
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduce la palabra numero " + (i + 1) + ": ");
            palabras.Add(Console.ReadLine());
        }
        string palabra;
        do
        {
            Console.Write("Introduce una palabra a buscar: (ENTER para salir)");
            palabra = Console.ReadLine();
            if (palabras.Contains(palabra))
            {
                Console.WriteLine("La palabra está entre las 10 iniciales.");
            }
            else
            {
                Console.WriteLine("La palabra no está entre las 10 iniciales.");
            }
        } while (palabra != "");
    }
}
