using System;
/*Amplía el proyecto del ejercicio 6.6.2 (Libro): la clase Libro tendrá un
segundo constructor que permita dar valores al autor y el título, pero no a la
ubicación, que tomará el valor por defecto "No detallada".*/
class PruebaDeLibro
{
    
    public static void Main()
    {
        string titulo;
        string autor;
        string ubicacion;
        Documento d = new Documento();
        d.SetTitulo();
        d.SetAutor();
        d.SetUbicacion();
        d.MostrarDocumento();
        Console.WriteLine();
        Console.WriteLine("Introduce el titulo de tu libro:");
        titulo = Console.ReadLine();
        Console.WriteLine("Introduce el autor de tu libro:");
        autor = Console.ReadLine();
        Console.WriteLine("Introduce la ubicacion de tu libro:");
        ubicacion = Console.ReadLine();
        Console.WriteLine();
        Libro l = new Libro(titulo, autor, ubicacion);
        Console.WriteLine();
        l.MostrarDocumento();
        l.SetPaginas();
        l.MostrarPaginas();
        Console.WriteLine();
        Libro l2 = new Libro();
        Console.WriteLine();
        l2.MostrarDocumento();
    }
}
