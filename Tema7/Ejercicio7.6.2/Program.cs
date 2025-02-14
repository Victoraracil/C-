using System;
using System.Collections.Generic;

/*Crea una versión alternativa del ejercicio 7.5.2, pero que tenga las
traducciones almacenadas en una tabla Hash.*/

class Program
{
    static void Main()
    {
        Dictionary<string, string> meses = new Dictionary<string, string>(500);
        meses.Add("enero", "january");
        meses.Add("febrero", "february");
        meses.Add("marzo", "march");
        meses.Add("abril", "april");
        meses.Add("mayo", "may");
        meses.Add("junio", "june");
        meses.Add("julio", "july");
        meses.Add("agosto", "august");
        meses.Add("septiembre", "september");
        meses.Add("octubre", "october");
        meses.Add("noviembre", "november");
        meses.Add("diciembre", "december");
        Console.Write("Introduce un mes en español: ");
        string mes = Console.ReadLine().ToLower();
        if (meses.ContainsKey(mes))
        {
            Console.WriteLine(meses[mes]);
        }
        else
        {
            Console.WriteLine("No conozco ese mes.");
        }
    }
}