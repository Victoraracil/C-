using System;
// Ejemplo_06_10a.cs
// Métodos "static"
// Introducción a C#, por Nacho Cabanes
/*Amplía el ejemplo 06_10a con un función "static" llamada
"EscribirCentrado", que escriba centrado horizontalmente el texto que se le
indique como parámetro.*/

class Ejemplo_06_10a
{
    static void Main()
    {
        Console.WriteLine("Escribe el texto que quieras centrar");
        string texto = Console.ReadLine();
        EscribirCentrado(texto);
        Console.WriteLine("Pulsa Intro para borrar");
        Console.ReadLine();
        Hardware.BorrarPantalla();
        Console.WriteLine("Borrado!");
    }
    public static void EscribirCentrado(string texto)
    {
        Console.SetCursorPosition((Console.WindowWidth - texto.Length) / 2, Console.CursorTop);
        Console.WriteLine(texto);
    }
}