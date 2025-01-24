using System;
// Ejemplo_06_10b.cs
// Alternativa a 06_10a, sin métodos "static"
// Introducción a C#, por Nacho Cabanes
/*Amplía el ejemplo 06_10b con un función llamada "EscribirCentrado", que
escriba centrado horizontalmente el texto que se le indique como parámetro. Al
contrario que en el ejercicio 6.10.1, esta versión no será "static".*/

class Ejemplo_06_10b
{
    static void Main()
    {
        Console.WriteLine("Escribe el texto que quieras centrar");
        string texto = Console.ReadLine();
        Ejemplo_06_10b ejemplo = new Ejemplo_06_10b();
        ejemplo.EscribirCentrado(texto);
        Console.WriteLine("Pulsa Intro para borrar");
        Console.ReadLine();
        Hardware miPantalla = new Hardware();
        miPantalla.BorrarPantalla();
        Console.WriteLine("Borrado!");
    }
    public void EscribirCentrado(string texto)
    {
        Console.SetCursorPosition((Console.WindowWidth - texto.Length) / 2, Console.CursorTop);
        Console.WriteLine(texto);
    }
}