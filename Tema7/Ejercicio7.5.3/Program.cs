using System;
using System.Collections.Generic;

/*Crea un traductor básico de C# a Pascal, que tenga las traducciones
almacenadas en una SortedList (por ejemplo, "{" se convertirá a "begin", "}" se
convertirá a "begin", "WriteLine" se convertirá a "WriteLn", "ReadLine" se convertirá
a "ReadLn", "void" se convertirá a "procedure" y "Console." se convertirá a una
cadena vacía. Úsalo para que el usuario teclee (o "copie y pegue") un fuente en C#
y mostrar su equivalente (que no será perfecto) en Pascal.*/
class Program
{
    static void Main()
    {
        SortedList<string, string> traductor = new SortedList<string, string>();
        traductor.Add("{", "begin");
        traductor.Add("}", "end");
        traductor.Add("WriteLine", "WriteLn");
        traductor.Add("ReadLine", "ReadLn");
        traductor.Add("void", "procedure");
        traductor.Add("Console.", "");
        Console.WriteLine("Introduce un código en C#:");
        string codigo = Console.ReadLine();
        foreach (KeyValuePair<string, string> par in traductor)
        {
            codigo = codigo.Replace(par.Key, par.Value);
        }
        Console.WriteLine("El código en Pascal sería:");
        Console.WriteLine(codigo);
    }
}
