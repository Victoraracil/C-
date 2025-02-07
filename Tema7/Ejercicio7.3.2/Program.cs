using System;
using System.Collections.Generic;

/*Crea un programa que pida frases al usuario, hasta que introduzca una
frase vacía. En ese momento, mostrará todas las frases que se habían introducido.*/
class Pragraman
{
    static void Main()
    {
        string texto = "";
        Queue<string> miCola = new Queue<string>();
        do
        {
            try
            {
                Console.Write("Dime una frase (ENTER para terminar): ");
                texto = Console.ReadLine();
                if (texto != "")
                    miCola.Enqueue(texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                texto = "a";
            }
        }
        while (texto != "");
        Console.Write("Los datos eran: ");
        while (miCola.Count > 0)
            Console.WriteLine("{0} ", miCola.Dequeue());
    }
}
