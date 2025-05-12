using System;
using System.Collections.Generic;
using System.IO;

/*(8.1.2) Crea una versión de la base de datos de ficheros (ejercicio 5.2.3), de modo
que todos los datos se vuelquen a un fichero de texto al terminar la ejecución del
programa. Deberás decidir qué formato usar, por ejemplo:
• Cada campo en una línea, con una línea en blanco adicional tras cada
registro.
• Cada campo en una línea, pero sin línea en blanco que actúe de separador.
• Todos los campos de cada registro en una misma línea, empleando un
carácter poco habitual que actué de separador de campos.
• Cada registro en una línea, además de una primera línea adicional que
contenga la cantidad de registros que se van a volcar, para facilitar la
lectura.
• Cualquier otra alternativa que te parezca razonable.*/

class Program
{
    static void Main(string[] args)
    {
        string fichero = "database.txt";
        List<string> registros = new List<string>();
        
        registros.Add("Juan Freco, 30, Ingeniero");
        registros.Add("Pepe Garcia, 25, Diseñador");
        registros.Add("Sam Rodriguez, 22, Desarrollador");
        
        using (StreamWriter writer = new StreamWriter(fichero))
        {
            writer.WriteLine(registros.Count);
            foreach (var registro in registros)
            {
                writer.WriteLine(registro);
            }
        }
        Console.WriteLine($"Los registros se han escrito correctamente en  {fichero}");
    }
}


