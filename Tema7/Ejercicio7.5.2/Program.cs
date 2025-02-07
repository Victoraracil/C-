using System;
using System.Collections.Generic;

/*Crea un programa que, cuando el usuario introduzca el nombre de un mes
en español (por ejemplo, "abril"), muestre su traducción en inglés (por ejemplo,
"april")*/

class Program
{
    static void Main()
    {
        Dictionary<string, string> meses = new Dictionary<string, string>();
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
