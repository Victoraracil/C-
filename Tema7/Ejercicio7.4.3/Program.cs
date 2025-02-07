using System;
using System.Collections.Generic;

/*Crea un programa que pida frases al usuario (hasta que introduzca una
línea vacía), las almacene en un ArrayList (o una lista de strings), lo ordene y lo
muestre ordenado en pantalla.*/
class Program
{
    public static void Main(string[] args)
    {
        List<string> frases = new List<string>();
        string frase;
        do
        {
            Console.WriteLine("Introduce una frase: ");
            frase = Console.ReadLine();
            if (frase != "")
            {
                frases.Add(frase);
            }
        } while (frase != "");
        frases.Sort();
        foreach (string f in frases)
        {
            Console.WriteLine(f);
        }
    }
}
